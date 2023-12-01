using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3___App.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Musisz podać datę!")]
        [Display(Name = "Data")]
        public DateTime? Data { get; set; }

        [Required(ErrorMessage = "Musisz wpisać miasto!")]
        [Display(Name = "Miasto")]
        public string Miasto { get; set; }

        [Required(ErrorMessage = "Musisz wpisać adres!")]
        [Display(Name = "Adres")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Musisz wpisać pokój!")]
        [Display(Name = "Pokój")]
        public Rooms Pokoj { get; set; }

        [Required(ErrorMessage = "Musisz wpisać właściciela!")]
        [Display(Name = "Właściciel")]
        public string Wlasciciel { get; set; }

        [Required(ErrorMessage = "Musisz wpisać cenę!")]
        [Display(Name = "Cena")]
        public decimal? Cena { get; set; }
        [HiddenInput]
        public DateTime Created { get; set; }
    }
}
