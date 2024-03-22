using System.ComponentModel.DataAnnotations;

namespace ContactsController.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string? Imię { get; set; }
		[Required]
		public string? Nazwisko { get; set; }
		[Required]
		[EmailAddress]
		public string? Email { get; set; }
		[Required]
		[MinLength(6)]
		public string? Hasło { get; set; }
		public string? Kategoria { get; set; }
		public string? PodKategoria { get; set; }
		[Required]
		public string? Telefon { get; set; }
		public DateTime DataUrodzin { get; set; }
	}


}

