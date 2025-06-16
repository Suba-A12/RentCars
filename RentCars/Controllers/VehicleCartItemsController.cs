using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RentCars.Data;
using RentCars.Models;


namespace RentCars.Controllers
{
    [Authorize(Roles = "Customer")]
    public class VehicleCartItemsController : Controller
    {
        public string VehicleCartId { get; set; }
        public const string CartSessionKey = "Username";
        private readonly ApplicationDbContext _context;

        public VehicleCartItemsController(ApplicationDbContext context)
        {
            this.VehicleCartId = "";
            _context = context;

        }
        
        public async Task<IActionResult> AddToCart(int id)
        {
            VehicleCartId = GetCartId();
            CartItems cartItem = new CartItems();
            cartItem = _context.CartItems.SingleOrDefault(c => c.Username == VehicleCartId && c.VehicleId == id);
            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists.
                cartItem = new CartItems
                {
                    VehicleId = id,
                    TotalAmout = (int)_context.Vehicle.SingleOrDefault(p => p.VehicleId == id).DailyRate,
                    Username = VehicleCartId,
                  //Vehicle = _context.Vehicle.SingleOrDefault(p => p.VehicleId == id),
                    NoOfCars = 1,
                    DateCreated = DateOnly.FromDateTime(DateTime.Now)
                };
                _context.CartItems.Add(cartItem);
            }
            else
            {
                  // If the item does exist in the cart,
                 // then add one to the quantity.
               cartItem.NoOfCars++;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("DisplayCartItems");
        }


        public string GetCartId()
        {
            var session = HttpContext.Session.GetString(CartSessionKey);
            if (session == null)
            {
                if (!string.IsNullOrWhiteSpace(User.Identity.Name))
                {
                    session = User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class.
                    Guid tempCartId = Guid.NewGuid();
                    session = tempCartId.ToString();
                }
            }
            return session.ToString();
        }

        public async Task<IActionResult> DeleteCartItem(int id)
        {
            var cartItemDelete = _context.CartItems.Find(id);

            if (cartItemDelete != null)
            {
                _context.CartItems.Remove(cartItemDelete);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(DisplayCartItems));
        }

        public List<CartItems> GetCartItems()
        {
            VehicleCartId = GetCartId();
            return _context.CartItems.Where(
            c => c.Username == VehicleCartId).ToList();
        }
        public IActionResult DisplayCartItems()
        {
            var cartitems = GetCartItems();
            ViewBag.count = cartitems.Count;
            return View(cartitems);
        }
        public async Task<IActionResult> CheckOut()
        {
            var username = User.Identity.Name;
            var cartItems = _context.CartItems.Where(ci => ci.Username == username).ToList();
            double TAmount = 0.0;

            foreach (var item in cartItems)
            {
                var total = item.TotalAmout * item.NoOfCars;
                TAmount = TAmount + total;
            }

            var paymentStatus = "Paid";
            var rntId = _context.Customer.Where(c => c.Email == username).FirstOrDefault().CustomerId;
            Invoice inv = new Invoice();
            inv.Date = DateOnly.FromDateTime(DateTime.Now);
            inv.TotalAmount = TAmount;
            inv.PaymentStatus = paymentStatus;
            inv.RentalId = rntId;
            _context.Invoice.Add(inv);

            await _context.SaveChangesAsync();

            return Redirect("/Payments/CheckOut");
        }

        // GET: CartItems
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CartItems.Include(r => r.Vehicle);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CartItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItems = await _context.CartItems
                .Include(r => r.Vehicle)
                .FirstOrDefaultAsync(m => m.CartId == id);
            if (cartItems == null)
            {
                return NotFound();
            }

            return View(cartItems);
        }

        // GET: CartItems/Create
        public IActionResult Create()
        {
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "VehicleId", "VehicleId");
            return View();
        }

        // POST: CartItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CartId,Username,NoOfCars,TotalAmout,DateCreated,VehicleId")] CartItems cartItems)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartItems);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "VehicleId", "VehicleId", cartItems.VehicleId);
            return View(cartItems);
        }

        // GET: CartItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItems = await _context.CartItems.FindAsync(id);
            if (cartItems == null)
            {
                return NotFound();
            }
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "VehicleId", "VehicleId", cartItems.VehicleId);
            return View(cartItems);
        }

        // POST: CartItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CartId,Username,NoOfCars,TotalAmout,DateCreated,VehicleId")] CartItems cartItems)
        {
            if (id != cartItems.CartId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartItems);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartItemsExists(cartItems.CartId))
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
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "VehicleId", "RoomId", cartItems.VehicleId);
            return View(cartItems);
        }

        // GET: CartItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItems = await _context.CartItems
                .Include(r => r.Vehicle)
                .FirstOrDefaultAsync(m => m.CartId == id);
            if (cartItems == null)
            {
                return NotFound();
            }

            return View(cartItems);
        }

        // POST: CartItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cartItems = await _context.CartItems.FindAsync(id);
            if (cartItems != null)
            {
                _context.CartItems.Remove(cartItems);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartItemsExists(int id)
        {
            return _context.CartItems.Any(e => e.CartId == id);
        }
    }
}
