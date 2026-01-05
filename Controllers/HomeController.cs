using BookSawNew.DAL;
using BookSawNew.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookSawNew.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _db;

        public HomeController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            List<Product> products = _db.Products
                .Include(p => p.Images)
                .Include(p => p.Categories)
                .ToList();
            return View(products);
        }

        public IActionResult Detail(int? id)
        {
            var product = _db.Products
                .Include(p => p.Images)
                .Include(p => p.Categories)
                .FirstOrDefault(p => p.Id == id);
            return View(product);
        }
    }
}
