using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MikesBallonaPaloozaExtravaganziaStore.Data;
using MikesBallonaPaloozaExtravaganziaStore.Models;

namespace MikesBallonaPaloozaExtravaganziaStore.Controllers
{
    public class BalloonsController : Controller
    {
        private readonly MikesBallonaPaloozaExtravaganziaStoreContext _context;

        public BalloonsController(MikesBallonaPaloozaExtravaganziaStoreContext context)
        {
            _context = context;
        }

        // GET: Balloons
        public async Task<IActionResult> Index()
        {
            return View(await _context.Balloons.ToListAsync());
        }

        // GET: Balloons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var balloons = await _context.Balloons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (balloons == null)
            {
                return NotFound();
            }

            return View(balloons);
        }

        // GET: Balloons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Balloons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Name,Colour,Event,Price,Rating")] Balloons balloons)
        {
            if (ModelState.IsValid)
            {
                _context.Add(balloons);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(balloons);
        }

        // GET: Balloons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var balloons = await _context.Balloons.FindAsync(id);
            if (balloons == null)
            {
                return NotFound();
            }
            return View(balloons);
        }

        // POST: Balloons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Name,Colour,Event,Price,Rating")] Balloons balloons)
        {
            if (id != balloons.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(balloons);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BalloonsExists(balloons.Id))
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
            return View(balloons);
        }

        // GET: Balloons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var balloons = await _context.Balloons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (balloons == null)
            {
                return NotFound();
            }

            return View(balloons);
        }

        // POST: Balloons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var balloons = await _context.Balloons.FindAsync(id);
            _context.Balloons.Remove(balloons);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BalloonsExists(int id)
        {
            return _context.Balloons.Any(e => e.Id == id);
        }
    }
}
