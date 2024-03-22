using ContactsController.Data;
using ContactsController.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactsController.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ApplicationDbContext _db;

		public CategoryController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
        {
			IEnumerable<Category> objCategoryList = _db.Kategorie.ToList();
			return View(objCategoryList);
		}


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            _db.Kategorie.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
