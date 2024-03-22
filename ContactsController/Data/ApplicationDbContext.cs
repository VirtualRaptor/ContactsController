using ContactsController.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsController.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Kategorie { get; set; }
    }
}
