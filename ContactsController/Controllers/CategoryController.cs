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
            if (ModelState.IsValid)
            {
                _db.Kategorie.Add(obj);
                _db.SaveChanges();
               
            }
            return View(obj);

        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryfromDb = _db.Kategorie.Find(id);
            if (categoryfromDb == null)
            {
                return NotFound();
            }
            return View(categoryfromDb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Kategorie.Add(obj);
                _db.SaveChanges();

            }
            return View(obj);

        }
    }
}
