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
        // ATTRIBUTE ROUTING w/ REGEX CONSTRAINTS
        //  (Section 2, Lecture 13)
        // OTHER CONSTRAINTS ->     min, max, minlength, maxlength, int, fload, guid

        //  /Movies/Random/YYYY/MM
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]   // Attribute Route w/ regex constraints
        public ActionResult Random()
        {

            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
			{
				new Customer { Name = "Customer 1" },
				new Customer { Name = "Customer 2" }
			};

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            // We've loaded the movie and customers objects into the viewModel RandomMovieViewModel and pass it:
            return View(viewModel);

        }

        // ATTRIBUTE ROUTING w/ REGEX CONSTRAINTS


        //  /Movies/ByReleaseDate
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        //  /Movies/Edit
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //  /Movies
        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }


        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
			{
				new Movie { Id = 1, Name = "Shrek"},
				new Movie { Id = 2, Name = "Wall-e"}
			};
        }

    }
}