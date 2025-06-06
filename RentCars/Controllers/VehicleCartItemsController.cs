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
        public const string CartSessionKey = "CartId";
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
                    Vehicle = _context.Vehicle.SingleOrDefault(p => p.VehicleId == id),
                    NoOfCars = 1,
                    DateCreated = DateOnly.MaxValue
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
            var custId = _context.Customer.Where(c => c.Email == username).FirstOrDefault().CustomerId;
            Invoice inv = new Invoice();
            inv.Date = DateOnly.FromDateTime(DateTime.Now);
            inv.TotalAmount = TAmount;
            inv.PaymentStatus = paymentStatus;
            inv.RentalId = custId;
            _context.Invoice.Add(inv);

            await _context.SaveChangesAsync();

            return Redirect("/Payments/CheckOut");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
