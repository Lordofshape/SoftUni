#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Country.Data;
using Country.Data.Models;

namespace Country.Controllers
{
    public class CounntriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CounntriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Counntries
        public async Task<IActionResult> Index()
        {
            return View(await _context.Countries.ToListAsync());
        }

        // GET: Counntries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var counntry = await _context.Countries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (counntry == null)
            {
                return NotFound();
            }

            return View(counntry);
        }

        // GET: Counntries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Counntries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Counntry counntry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(counntry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(counntry);
        }

        // GET: Counntries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var counntry = await _context.Countries.FindAsync(id);
            if (counntry == null)
            {
                return NotFound();
            }
            return View(counntry);
        }

        // POST: Counntries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Counntry counntry)
        {
            if (id != counntry.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(counntry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CounntryExists(counntry.Id))
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
            return View(counntry);
        }

        // GET: Counntries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var counntry = await _context.Countries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (counntry == null)
            {
                return NotFound();
            }

            return View(counntry);
        }

        // POST: Counntries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var counntry = await _context.Countries.FindAsync(id);
            _context.Countries.Remove(counntry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CounntryExists(int id)
        {
            return _context.Countries.Any(e => e.Id == id);
        }
    }
}
