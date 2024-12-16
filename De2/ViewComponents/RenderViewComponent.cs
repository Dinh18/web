using De2.Models;
using Microsoft.AspNetCore.Mvc;

namespace De2.ViewComponents
{
	public class RenderViewComponent : ViewComponent
	{ 
		public NewShopContext db;
		public RenderViewComponent(NewShopContext db) {
			this.db = db;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var items = db.NavItems.ToList();
			return View("RenderHeader", items);
		}
	}
}
