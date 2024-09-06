using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using System.Collections.Generic;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            var filmListesi = new List<Movie> ()
            {
                new Movie { Title = "film 1", Description="açıklama 1", Director= "Yönetmen 1", Players=new string[] {"oyuncu 1", "oyuncu 2"}, ImageUrl="1.jpeg" },
                new Movie { Title = "film 2", Description="açıklama 2", Director= "Yönetmen 2", Players=new string[] {"oyuncu 1", "oyuncu 2"}, ImageUrl="1.jpeg"},
                new Movie { Title = "film 3", Description="açıklama 3", Director= "Yönetmen 3", Players=new string[] {"oyuncu 1", "oyuncu 2"}, ImageUrl = "1.jpeg"}
            };
            return View("Movies", filmListesi);
        }
        public string Details()
        {
            return "Film Detayı";
        }
    }
}
