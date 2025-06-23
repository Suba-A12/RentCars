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
    public class MaintenancesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MaintenancesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Maintenances
        public async Task<IActionResult> Index(int? vehicleId)
        {
            ViewData["Vehicles"] = new SelectList(_context.Vehicle, "VehicleId", "VehicleId");
            var maintenances = _context.Maintenance.Include(m => m.Vehicle);
            if (vehicleId.HasValue)
            {
                return View(await maintenances.Where(m => m.VehicleId == vehicleId.Value).ToListAsync());
            }
            return View(await maintenances.ToListAsync());

            //var applicationDbContext = _context.Maintenance.Include(m => m.Vehicle);
            //return View(await applicationDbContext.ToListAsync());
        }

        // GET: Maintenances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenance = await _context.Maintenance
                .Include(m => m.Vehicle)
                .FirstOrDefaultAsync(m => m.MaintenanceId == id);
            if (maintenance == null)
            {
                return NotFound();
            }

            return View(maintenance);
        }

        // GET: Maintenances/Create
        public IActionResult Create()
        {
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "VehicleId", "VehicleId");
            return View();
        }

        // POST: Maintenances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaintenanceId,Description,Date,Cost,VehicleId")] Maintenance maintenance)
        {
            //if (ModelState.IsValid)
            //{
                _context.Add(maintenance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            //}
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "VehicleId", "VehicleId", maintenance.VehicleId);
            return View(maintenance);
        }

        // GET: Maintenances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenance = await _context.Maintenance.FindAsync(id);
            if (maintenance == null)
            {
                return NotFound();
            }
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "VehicleId", "VehicleId", maintenance.VehicleId);
            return View(maintenance);
        }

        // POST: Maintenances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaintenanceId,Description,Date,Cost,VehicleId")] Maintenance maintenance)
        {
            if (id != maintenance.MaintenanceId)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            //{
                try
                {
                    _context.Update(maintenance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaintenanceExists(maintenance.MaintenanceId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            //}
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "VehicleId", "VehicleId", maintenance.VehicleId);
            return View(maintenance);
        }

        // GET: Maintenances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenance = await _context.Maintenance
                .Include(m => m.Vehicle)
                .FirstOrDefaultAsync(m => m.MaintenanceId == id);
            if (maintenance == null)
            {
                return NotFound();
            }

            return View(maintenance);
        }

        // POST: Maintenances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var maintenance = await _context.Maintenance.FindAsync(id);
            if (maintenance != null)
            {
                _context.Maintenance.Remove(maintenance);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaintenanceExists(int id)
        {
            return _context.Maintenance.Any(e => e.MaintenanceId == id);
        }
    }
}
