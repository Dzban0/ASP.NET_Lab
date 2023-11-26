using Microsoft.AspNetCore.Mvc;
using Labolatorium_3.Models;
using System.Reflection;

namespace Labolatorium_3.Controllers
{
    public class BookController : Controller
    {
        static Dictionary<int, Book> _book = new Dictionary<int, Book>();
        public IActionResult Index()
        {
            return View(_book);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book model) {
        if(ModelState.IsValid)
            {
                int id = _book.Keys.Count != 0 ? _book.Keys.Max() : 0;
                model.Id = id + 1;
                _book.Add(model.Id, model);

            }
            return View(model);
        }
    }
}
