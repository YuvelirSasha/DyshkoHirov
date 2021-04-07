using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Context;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class ClassRoomController : Controller
    {
        private readonly SchoolDatabaseContext _contex;

        public ClassRoomController(SchoolDatabaseContext contex)
        {
            _contex = contex;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _contex.ClassRooms.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _contex.ClassRooms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Other")] ClassRoom room)
        {
            if (ModelState.IsValid)
            {
                _contex.Add(room);
                await _contex.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(room);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _contex.ClassRooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }
            return View(room);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Other")] ClassRoom room)
        {
            if (id != room.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _contex.Update(room);
                    await _contex.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(room.Id))
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
            return View(room);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _contex.ClassRooms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var room = await _contex.ClassRooms.FindAsync(id);
            _contex.ClassRooms.Remove(room);
            await _contex.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _contex.ClassRooms.Any(e => e.Id == id);
        }
    }
}
