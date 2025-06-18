using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RentCars.Data;
using RentCars.Models;
using Stripe;
using Stripe.Checkout;

namespace RentCars.Controllers
{
    public class PaymentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly StripeSettings _stripeSettings;
        private readonly IConfiguration _configuration;

        public PaymentsController(ApplicationDbContext context, IOptions<StripeSettings> stripeSettings, IConfiguration configuration)
        {
            _context = context;
            _stripeSettings = stripeSettings.Value;
            _configuration = configuration;
        }

        //public IActionResult Success()
        //{
        //    var amount = TempData["Amount"] != null ? Convert.ToDouble(TempData["Amount"]) : 0.0;
        //    int invoiceId = 1;   
        //    var payment = new Payment
        //    {
        //        Amount = amount,
        //        PaymentDate = DateOnly.FromDateTime(DateTime.Now),
        //        PaymentType = "Stripe",
        //        InvoiceId = invoiceId
        //    };

        //    _context.Payment.Add(payment);
        //    _context.SaveChanges();
        //    return View();
        //}
        public async Task<IActionResult> Success(string session_id)
        {
            // 1. Fetch the Stripe session
            var service = new Stripe.Checkout.SessionService();
            var session = await service.GetAsync(session_id);

            // 2. Get the amount paid (Stripe stores in cents)
            double amount = session.AmountTotal.HasValue ? session.AmountTotal.Value / 100.0 : 0.0;

            // 3. Get the current user and their rental (adjust as needed)
            var username = User.Identity.Name;
            var rental = _context.Rental.FirstOrDefault(r => r.Customer.Email == username);
            if (rental == null)
                return BadRequest("No rental found for user.");

            // 4. Create the invoice
            var invoice = new RentCars.Models.Invoice
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                TotalAmount = amount,
                PaymentStatus = "Paid",
                RentalId = rental.RentalId
            };
            _context.Invoice.Add(invoice);
            await _context.SaveChangesAsync(); // Save to get InvoiceId

            // 5. Create the payment record
            var payment = new Payment
            {
                Amount = amount,
                PaymentDate = DateOnly.FromDateTime(DateTime.Now),
                PaymentType = "Stripe",
                InvoiceId = invoice.InvoiceId
            };
            _context.Payment.Add(payment);
            await _context.SaveChangesAsync();

            return View();
        }


        public IActionResult Cancel()
        {
            return View();
        }

        public IActionResult CheckOut()
        {
            ViewBag.StripePublishableKey = _configuration["Stripe:PublishableKey"];
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCheckOutSession()
        {

            var username = User.Identity.Name;
            var cartItems = _context.CartItems.Where(ci => ci.Username == username).ToList();
            var TAmount = 0.0;

            foreach (var item in cartItems)
            {
                var total = item.TotalAmout * item.NoOfCars;
                TAmount = TAmount + total;
            }
            var successUrl = $"{Request.Scheme}://{Request.Host}/Payments/Success?session_id={{CHECKOUT_SESSION_ID}}";
            var cancelUrl = $"{Request.Scheme}://{Request.Host}/Payments/Cancel";

            // Create a Stripe Checkout Session
            var options = new SessionCreateOptions
            {

                PaymentMethodTypes = new List<string> { "card" },
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                            PriceData = new SessionLineItemPriceDataOptions
                            {
                            Currency = "sgd",
                            UnitAmount = (long?)TAmount*100,
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = "Total Amount",
                                Description ="Amount to charge in the Credit Card"
                            }

                        },
                        Quantity = 1,
                    },
                },
                Mode = "payment",
                SuccessUrl = successUrl,   // <-- Use the raw string here
                CancelUrl = cancelUrl,

                //SuccessUrl = Url.Action("Success", "Payments", null, Request.Scheme),
                //CancelUrl = Url.Action("Cancel", "Payments", null, Request.Scheme),
            };

            foreach (var pro in cartItems)
            {
                _context.CartItems.Remove(pro);
            }

            await _context.SaveChangesAsync();

            var service = new Stripe.Checkout.SessionService();
            var session = await service.CreateAsync(options);
            // Redirect to Stripe SuccessUrl or CancelUrl
            return Redirect(session.Url);
        }

        // GET: Payments
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Payment.Include(p => p.Invoice);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Payments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payment = await _context.Payment
                .Include(p => p.Invoice)
                .FirstOrDefaultAsync(m => m.PaymentId == id);
            if (payment == null)
            {
                return NotFound();
            }

            return View(payment);
        }

        // GET: Payments/Create
        public IActionResult Create()
        {
            ViewData["InvoiceId"] = new SelectList(_context.Invoice, "InvoiceId", "InvoiceId");
            return View();
        }

        // POST: Payments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PaymentId,Amount,PaymentDate,PaymentType,InvoiceId")] Payment payment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(payment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InvoiceId"] = new SelectList(_context.Invoice, "InvoiceId", "InvoiceId", payment.InvoiceId);
            return View(payment);
        }

        // GET: Payments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payment = await _context.Payment.FindAsync(id);
            if (payment == null)
            {
                return NotFound();
            }
            ViewData["InvoiceId"] = new SelectList(_context.Invoice, "InvoiceId", "InvoiceId", payment.InvoiceId);
            return View(payment);
        }

        // POST: Payments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PaymentId,Amount,PaymentDate,PaymentType,InvoiceId")] Payment payment)
        {
            if (id != payment.PaymentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(payment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentExists(payment.PaymentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["InvoiceId"] = new SelectList(_context.Invoice, "InvoiceId", "InvoiceId", payment.InvoiceId);
            return View(payment);
        }

        // GET: Payments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payment = await _context.Payment
                .Include(p => p.Invoice)
                .FirstOrDefaultAsync(m => m.PaymentId == id);
            if (payment == null)
            {
                return NotFound();
            }

            return View(payment);
        }

        // POST: Payments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var payment = await _context.Payment.FindAsync(id);
            if (payment != null)
            {
                _context.Payment.Remove(payment);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentExists(int id)
        {
            return _context.Payment.Any(e => e.PaymentId == id);
        }
    }
}
