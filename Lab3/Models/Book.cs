using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Labolatorium_3.Models
{
    public class Book
    {

        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podać tytuł książki.")]
        public string Tytul { get; set; }

        [Required(ErrorMessage = "Proszę podać autora.")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Proszę podać liczbę stron.")]
        public int Liczba_stron { get; set; }

        [Required(ErrorMessage = "Proszę podać numer ISBN.")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Proszę rok wydania książki.")]
        public string Rok_wydania { get; set; }

        [Required(ErrorMessage = "Proszę podać nazwę wydawnictwa.")]
        public string Wydawnictwo { get; set; }

    }
}
