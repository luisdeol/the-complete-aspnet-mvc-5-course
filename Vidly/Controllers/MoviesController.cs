using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie{ Id = 1, Name = "Star Wars!" };
            var customers = new List<Customer>
            {
                new Customer{ Name = "Customer 1"},
                new Customer{ Name = "Customer 2"}
            };
            
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie {Id = 1, Name = "Wall-E"},
                new Movie {Id = 2, Name = "Lord of the Rings"}
            };
            return View(movies);
        }
    }
}