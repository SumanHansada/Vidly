using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Venom"},
                new Movie {Id = 2, Name = "SpiderMan"}
            };
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Venom" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Suman"},
                new Customer {Name = "Kumar"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(01, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}