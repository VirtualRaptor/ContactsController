using ContactsController.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ContactsController.Controllers
{
    // Kontroler główny aplikacji obsługujący strony główne i błędy
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Konstruktor kontrolera, wstrzykujący logger
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Akcja wyświetlająca stronę główną
        public IActionResult Index()
        {
            return View();
        }

        // Akcja wyświetlająca stronę prywatności
        public IActionResult Privacy()
        {
            return View();
        }

        // Akcja obsługująca błędy
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
