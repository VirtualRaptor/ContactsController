using ContactsController.Data;
using ContactsController.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ContactsController.Controllers
{
    // Kontroler obsługujący operacje na kontaktach
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _db;

        // Konstruktor kontrolera, wstrzykujący kontekst bazy danych
        public ContactController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Akcja wyświetlająca listę kontaktów
        public IActionResult Index()
        {
            IEnumerable<Contact> objContactList = _db.Contacts.ToList();
            return View(objContactList);
        }

        // Akcja wyświetlająca formularz dodawania nowego kontaktu
        public IActionResult Create()
        {
            return View();
        }

        // Akcja obsługująca dodawanie nowego kontaktu
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Contact obj)
        {
            if (ModelState.IsValid)
            {
                _db.Contacts.Add(obj);
                _db.SaveChanges();
            }
            return View(obj);
        }

        // Akcja wyświetlająca formularz edycji kontaktu
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var contactFromDb = _db.Contacts.Find(id);
            if (contactFromDb == null)
            {
                return NotFound();
            }
            return View(contactFromDb);
        }

        // Akcja obsługująca edycję kontaktu
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Contact obj)
        {
            if (ModelState.IsValid)
            {
                _db.Contacts.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // Akcja wyświetlająca formularz potwierdzenia usunięcia kontaktu
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var contactFromDb = _db.Contacts.Find(id);
            if (contactFromDb == null)
            {
                return NotFound();
            }
            return View(contactFromDb);
        }

        // Akcja obsługująca usuwanie kontaktu
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Contacts.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Contacts.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
