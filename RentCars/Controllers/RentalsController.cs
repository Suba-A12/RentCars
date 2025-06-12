using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentCars.Data;
using RentCars.Models;

namespace RentCars.Controllers
{
    public class RentalsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RentalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Rentals
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Rental.Include(r => r.Customer).Include(r => r.Staff);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Rentals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rental = await _context.Rental
                .Include(r => r.Customer)
                .Include(r => r.Staff)
                .FirstOrDefaultAsync(m => m.RentalId == id);
            if (rental == null)
            {
                return NotFound();
            }

            return View(rental);
        }

        //GET: Rentals/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId");
            ViewData["StaffId"] = new SelectList(_context.Staff, "StaffId", "StaffId");
            
            return View();
        }

        // POST: Rentals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RentalId,StartDate,EndDate,BookingStatus,EstimatedRentalCost,Latefee,SecurityDeposit,TotalAmount,CustomerId,StaffId")] Rental rental, int id)
        {
            //if (ModelState.IsValid)
            //{
            var vehicleId = id;
            rental.StaffId = 1;
            var username = User.Identity.Name;
            var customerId = _context.Customer.Where(g => g.Email == username).FirstOrDefault().CustomerId;
            rental.CustomerId = customerId;
            _context.Add(rental);

            await _context.SaveChangesAsync();

            RentalDetail rnt = new RentalDetail();
            rnt.NumberOfDays = 1;
            rnt.DailyRate = _context.Vehicle.Where(r => r.VehicleId == vehicleId).FirstOrDefault().DailyRate;
            rnt.RentalId = rental.RentalId;
            rnt.VehicleId = Convert.ToInt32(vehicleId);
            _context.Add(rnt);
            await _context.SaveChangesAsync();
            return RedirectToAction("AddToCart", "VehicleCartItems", new { id = id });
            //}
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId", rental.CustomerId);
            ViewData["StaffId"] = new SelectList(_context.Staff, "StaffId", "StaffId", rental.StaffId);
            return View(rental);

            //_context.Add(rental);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            

        }

        // GET: Rentals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rental = await _context.Rental.FindAsync(id);
            if (rental == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId", rental.CustomerId);
            ViewData["StaffId"] = new SelectList(_context.Staff, "StaffId", "StaffId", rental.StaffId);
            return View(rental);
        }

        // POST: Rentals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RentalId,StartDate,EndDate,BookingStatus,EstimatedRentalCost,Latefee,SecurityDeposit,TotalAmount,CustomerId,StaffId")] Rental rental)
        {
            if (id != rental.RentalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rental);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentalExists(rental.RentalId))
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
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId", rental.CustomerId);
            ViewData["StaffId"] = new SelectList(_context.Staff, "StaffId", "StaffId", rental.StaffId);
            return View(rental);
        }

        // GET: Rentals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rental = await _context.Rental
                .Include(r => r.Customer)
                .Include(r => r.Staff)
                .FirstOrDefaultAsync(m => m.RentalId == id);
            if (rental == null)
            {
                return NotFound();
            }

            return View(rental);
        }

        // POST: Rentals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rental = await _context.Rental.FindAsync(id);
            if (rental != null)
            {
                _context.Rental.Remove(rental);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool RentalExists(int id)
        {
            return _context.Rental.Any(e => e.RentalId == id);
        }

    }
}
