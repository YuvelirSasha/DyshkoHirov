using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prodject_ПРІС.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodject_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.ClassRooms.ToListAsync());
        }

        //public async Task<IActionResult> Details(int? id)
    }
}
