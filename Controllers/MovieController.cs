using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Infrastructure;

namespace MbmStore.Controllers
{



    public class MovieController : Controller
    {
        public IActionResult Index()
        {
       
            //List<Movie> movies = Repository.Movies.ToList();
            //ViewBag.Movies = movies;
            



            ////////
            //Movie Movie1 = new Movie("Jungle Book", 160.50m, "junglebook.jpg", "hans");
            //Movie Movie2 = new Movie("NiceMovie", 99.50m, "gladiator.jpg", "peter");
            //Movie Movie3 = new Movie("NotNiceMovie", 160.50m, "junglebook.jpg", "Kurt");

            ////// create a new Movie object with instance name jungleBook
            ////var jungleBook = new Movie("Jungle Book", 160.50m, "junglebook.jpg","hans");
            ////var randomMovie1 = new Movie("Nicebook", 99.50m, "gladiator.jpg", "peter");
            ////var randomMovie2 = new Movie("notnice", 16.50m, "forrest-gump.jpg", "kurt");

            //// assign a ViewBag property to the new Movie object

            //List<Movie> MovieList = new List<Movie>();

            //MovieList.Add(Movie1);
            //MovieList.Add(Movie2);
            //MovieList.Add(Movie3);

            //ViewBag.Movies = MovieList;
           

            // return the default view
            return View();
        }

    }
   
}

