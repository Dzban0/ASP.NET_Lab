using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Contact
    {
        [HiddenInput]
        public string Id { get; set; }
        [Required(ErrorMessage = "Musisz wpisać imię")]
        [StringLength(maximumLength: 100, ErrorMessage = "Zbyt długie imię. Maksumalnie 100")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Musisz podać email")]
        [EmailAddress(ErrorMessage = "Nieporawny adres email")]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Niepoprawny numer telefonu, wpisz cyfry")] 
        public string Phone { get; set; }
        public DateTime Birth { get; set; }

    }
}
