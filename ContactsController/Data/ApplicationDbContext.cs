using ContactsController.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ContactsController.Data
{
    // Kontekst bazy danych aplikacji
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // Metoda konfigurująca mapowanie modelu do tabeli
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().ToTable("Kategorie"); // Mapowanie modelu Category do tabeli Kategorie
        }

        // Zbiór danych kategorii kontaktów
        public DbSet<Category> Kategorie { get; set; }
    }
}
