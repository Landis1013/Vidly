using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
	public class MoviesController : Controller
	{

		// -- Get Movies from Database --
		private ApplicationDbContext _context;

		public MoviesController()
		{
			_context = new ApplicationDbContext();
		}
		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}
		// -- Get Movies from Database --


		public ViewResult Index()
		{
			var movies = _context.Movies.Include(c => c.Genre).ToList();
			return View(movies);
		}


		// ATTRIBUTE ROUTING w/ REGEX CONSTRAINTS
		//  (Section 2, Lecture 13)
		// OTHER CONSTRAINTS ->     min, max, minlength, maxlength, int, fload, guid
		//[Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]   // Attribute Route w/ regex constraints
		public ActionResult Random(int id)
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

			//We've loaded the movie and customers objects into the viewModel RandomMovieViewModel and pass it:
			return View(viewModel);

		}
		// ATTRIBUTE ROUTING w/ REGEX CONSTRAINTS

		public ActionResult Details(int id)
		{
						
			var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

			if (movie == null)
				return HttpNotFound();

			return View(movie);

		}


	}
}