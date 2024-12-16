using De2.Models;
using Microsoft.AspNetCore.Mvc;

namespace De2.Controllers
{
	public class ProductController : Controller
	{
		private NewShopContext db;
		public ProductController(NewShopContext db)
		{
			this.db = db;
		}

		public IActionResult Index()
		{
			var products = db.Products.OrderBy(p => p.UnitPrice).Take(4).ToList();
			return View(products);
		}

		public IActionResult SearchProduct(string keyword)
		{
			var products = db.Products.Where(p => p.Name.ToLower().Contains(keyword.ToLower()));
			return PartialView(products);
		}
		[HttpGet]
		public IActionResult SignUp()
		{
			return View();
		}
		[HttpPost]
		public IActionResult SignUp(Customer cus)
		{
			if(ModelState.IsValid)
			{
				db.Add(cus);
				db.SaveChanges();
				return RedirectToAction("index");
			}
			return View();
		}
	}
}
