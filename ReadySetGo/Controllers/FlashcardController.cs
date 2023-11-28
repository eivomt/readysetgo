using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReadySetGo.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReadySetGo.Controllers
{
    public class FlashcardController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var flashcards = new List<Flashcard>();

            var flashcard1 = new Flashcard(1, "Sannhet", "Truth");

            var flashcard2 = new Flashcard(2, "Mot", "Courage");

            flashcards.Add(flashcard1);
            flashcards.Add(flashcard2);

            ViewBag.CurrentViewName = "List of flashcards";
            return View(flashcards);
        }
    }
}

