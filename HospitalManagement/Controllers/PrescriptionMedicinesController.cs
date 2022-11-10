using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitalManagementSystem.Models;

namespace HospitalManagement.Controllers
{
    public class PrescriptionMedicinesController : Controller
    {
        private readonly AppDbContext _context;
        private int prescriptionId;

        public PrescriptionMedicinesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: PrescriptionMedicines
        public async Task<IActionResult> Index(int prescriptionId)
        {
            if(prescriptionId == 0)
            {
                Console.WriteLine("0");
                //this.prescriptionId = Convert.ToInt32(TempData["PresId"]);
            }
            else 
            {
                this.prescriptionId = prescriptionId;
            }
            
            var appDbContext = _context.PrescriptionMedicines.Include(p => p.PrescriptionAssociated).Include(p => p.medicine).Where(p => p.PrescriptionId == prescriptionId);
            ViewBag.PrescriptionId = prescriptionId;
            return View(await appDbContext.ToListAsync());
        }

        /*public async Task<IActionResult> Index()
        {
            var appDbContext = _context.PrescriptionMedicines.Include(p => p.PrescriptionAssociated).Include(p => p.medicine);
            return View(await appDbContext.ToListAsync());
        }*/

        // GET: PrescriptionMedicines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PrescriptionMedicines == null)
            {
                return NotFound();
            }

            var prescriptionMedicine = await _context.PrescriptionMedicines
                .Include(p => p.PrescriptionAssociated)
                .Include(p => p.medicine)
                .FirstOrDefaultAsync(m => m.PrescriptionId == id);
            if (prescriptionMedicine == null)
            {
                return NotFound();
            }

            return View(prescriptionMedicine);
        }

        // GET: PrescriptionMedicines/Create
        public IActionResult Create(int prescriptionId)
        {
            if(prescriptionId != 0)
            {
                this.prescriptionId = prescriptionId;
                Console.WriteLine(prescriptionId);
                Console.WriteLine(this.prescriptionId);
            }
            //ViewData["PrescriptionId"] = prescriptionId;
            //ViewData["PrescriptionId"] = new SelectList(_context.Prescriptions, "Id", "Id");
            ViewBag.PrescriptionId = this.prescriptionId;
            ViewData["medicineId"] = new SelectList(_context.Medicines, "Id", "Id");
            return View();
        }

        // POST: PrescriptionMedicines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("medicineId,dose,noOfTablets,PrescriptionId")] PrescriptionMedicine prescriptionMedicine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prescriptionMedicine);
                await _context.SaveChangesAsync();
                //TempData["PresId"] = prescriptionMedicine.PrescriptionId;
                //string path = "Index/" + prescriptionMedicine.PrescriptionId;
                //Console.WriteLine(path);
                return RedirectToAction("Index",new { prescriptionId = prescriptionMedicine.PrescriptionId });
                //return RedirectToAction("Index?PrescriptionId=" + prescriptionMedicine.PrescriptionId);
            }
            ViewData["PrescriptionId"] = new SelectList(_context.Prescriptions, "Id", "Id", prescriptionMedicine.PrescriptionId);
            ViewData["medicineId"] = new SelectList(_context.Medicines, "Id", "Id", prescriptionMedicine.medicineId);
            return View(prescriptionMedicine);
        }

        // GET: PrescriptionMedicines/Edit/5
        /*public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PrescriptionMedicines == null)
            {
                return NotFound();
            }

            var prescriptionMedicine = await _context.PrescriptionMedicines.FindAsync(id);
            if (prescriptionMedicine == null)
            {
                return NotFound();
            }
            ViewData["PrescriptionId"] = new SelectList(_context.Prescriptions, "Id", "Id", prescriptionMedicine.PrescriptionId);
            ViewData["medicineId"] = new SelectList(_context.Medicines, "Id", "Id", prescriptionMedicine.medicineId);
            return View(prescriptionMedicine);
        }*/

        public async Task<IActionResult> Edit(int? prescriptionId, int? medId)
        {
            if (medId == null || prescriptionId == null || _context.PrescriptionMedicines == null)
            {
                return NotFound();
            }

            var prescriptionMedicine = await _context.PrescriptionMedicines.FindAsync(prescriptionId, medId);
            if (prescriptionMedicine == null)
            {
                return NotFound();
            }
            ViewData["PrescriptionId"] = new SelectList(_context.Prescriptions, "Id", "Id", prescriptionMedicine.PrescriptionId);
            ViewData["medicineId"] = new SelectList(_context.Medicines, "Id", "Id", prescriptionMedicine.medicineId);
            return View(prescriptionMedicine);
        }

        // POST: PrescriptionMedicines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int prescriptionId, int medId, [Bind("medicineId,dose,noOfTablets,PrescriptionId")] PrescriptionMedicine prescriptionMedicine)
        {
            if (prescriptionId != prescriptionMedicine.PrescriptionId)
            {
                return NotFound();
            }

            if (medId != prescriptionMedicine.medicineId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prescriptionMedicine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrescriptionMedicineExists(prescriptionMedicine.PrescriptionId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", new { prescriptionId = prescriptionMedicine.PrescriptionId });
            }
            ViewData["PrescriptionId"] = new SelectList(_context.Prescriptions, "Id", "Id", prescriptionMedicine.PrescriptionId);
            ViewData["medicineId"] = new SelectList(_context.Medicines, "Id", "Id", prescriptionMedicine.medicineId);
            return View(prescriptionMedicine);
        }

        // GET: PrescriptionMedicines/Delete/5
        /*public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PrescriptionMedicines == null)
            {
                return NotFound();
            }

            var prescriptionMedicine = await _context.PrescriptionMedicines
                .Include(p => p.PrescriptionAssociated)
                .Include(p => p.medicine)
                .FirstOrDefaultAsync(m => m.PrescriptionId == id);
            if (prescriptionMedicine == null)
            {
                return NotFound();
            }

            return View(prescriptionMedicine);
        }*/

        public async Task<IActionResult> Delete(int? prescriptionId, int? medId)
        {
            if (prescriptionId == null || medId == null || _context.PrescriptionMedicines == null)
            {
                return NotFound();
            }

            var prescriptionMedicine = await _context.PrescriptionMedicines
                .Include(p => p.PrescriptionAssociated)
                .Include(p => p.medicine)
                .FirstOrDefaultAsync(m=> m.PrescriptionId==prescriptionId & m.medicineId == medId);
            if (prescriptionMedicine == null)
            {
                return NotFound();
            }

            return View(prescriptionMedicine);
        }

        // POST: PrescriptionMedicines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int prescriptionId, int medId)
        {
            if (_context.PrescriptionMedicines == null)
            {
                return Problem("Entity set 'AppDbContext.PrescriptionMedicines'  is null.");
            }
            var prescriptionMedicine = await _context.PrescriptionMedicines.FindAsync(prescriptionId, medId);
            if (prescriptionMedicine != null)
            {
                _context.PrescriptionMedicines.Remove(prescriptionMedicine);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { prescriptionId = prescriptionMedicine.PrescriptionId });
        }

        private bool PrescriptionMedicineExists(int id)
        {
          return _context.PrescriptionMedicines.Any(e => e.PrescriptionId == id);
        }
    }
}
