using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SWAS.Data;
using SWAS.Models;
using System.Diagnostics;

namespace SWAS.Controllers
{
    public class TestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestController(ApplicationDbContext context)
        {
           _context = context;
        }

        public async Task <IActionResult> Index()
        {
            return View(await _context.Usuario.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
