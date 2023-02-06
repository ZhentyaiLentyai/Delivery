using DataBase;
using Delivery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace Delivery.Controllers
{
    public class HomeController : Controller
    {
        private EFDBContext _context;
        public HomeController(EFDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Base> _dirs = _context.Base.ToList();
            return View(_dirs);
        }

        [HttpGet("FullInfo/{id}")]
        public IActionResult FullInfo(int id)
        {
            Base _base = _context.Base.FirstOrDefault(b => b.Id == id);
            return View(_base);
        }

        [HttpGet("/Home/Delete/{id}")]
        [ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            Base _base = _context.Base.FirstOrDefault(b => b.Id == id);
            _context.Base.Remove(_base);
            _context.SaveChanges();
            return Redirect("/Home/Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}