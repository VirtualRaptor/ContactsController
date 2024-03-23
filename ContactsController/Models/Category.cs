using System;
using System.ComponentModel.DataAnnotations;

namespace ContactsController.Models
{
    // Model reprezentujący kontakt
    public class Category
    {
        [Key]
        public int Id { get; set; } // Identyfikator kontaktu

        public string? Imię { get; set; } // Imię kontaktu

        public string? Nazwisko { get; set; } // Nazwisko kontaktu

        [EmailAddress(ErrorMessage = "Nieprawidłowy format adresu email")]
        public string? Email { get; set; } // Adres email kontaktu

        [MinLength(6, ErrorMessage = "Hasło musi mieć co najmniej 6 znaków")]
        public string? Hasło { get; set; } // Hasło kontaktu

        public string? Kategoria { get; set; } // Kategoria kontaktu

        public string? PodKategoria { get; set; } // Podkategoria kontaktu

        public string? Telefon { get; set; } // Numer telefonu kontaktu

        public DateTime DataUrodzin { get; set; } // Data urodzin kontaktu
    }
}
