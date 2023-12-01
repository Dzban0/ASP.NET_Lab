using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3___App.Models
{
    public enum Rooms
    {
        [Display(Name = "Jednoosobowy")]
        Jednoosobowy,

        [Display(Name = "Dwuosobowy")]
        Dwuosobowy,

        [Display(Name = "Apartament")]
        Apartament,

        [Display(Name = "Studio")]
        Studio,
    }
}
