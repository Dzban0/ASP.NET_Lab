using Lab2.Models;
using Microsoft.AspNetCore.Mvc;


/***
 * wysłanie żądania do formularza (potrzebna akcja w kontrolerze do formularza)
 * użytkownik wypełnia formularz i submituje
 * wysłanie żądania z danymi formularza (potrzebna akcja odbierajaca dane)
 * obliczenie i zwrócenie widoku z wynikami
 * 
 */

namespace Lab2.Controllers
{

    public enum Operators
    {
        ADD, SUB, MUL, DIV
    }
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result([FromForm] Calculator model)
        {
            if(!model.IsValid())
                return View("Error");
            return View(model);
        }
    }
}
