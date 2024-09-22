using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Restaurant.Data;
using Restaurant.Models;

namespace Restaurant.Controllers
{
    public class ProductController : Controller
    {
        private Repository<Product> products;

        public ProductController(ApplicationDbContext context)
        {
            this.products = new Repository<Product>(context);
        }
        public async Task<IActionResult> Index()
        {
            return View(await products.GetAllAsync());
        }
    }
}
