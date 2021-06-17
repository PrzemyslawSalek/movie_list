using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieList.Models;

namespace MovieList.Controllers
{
    public class MovieController : Controller
    {
        private static IList<MovieModel> movies = new List<MovieModel>()
        {
            new MovieModel(){MovieId = 1, Name = "Pulp Fiction", Description = "Best film", Watched = false},
            new MovieModel(){MovieId = 2, Name = "Breaking Bad", Description = "Best serial", Watched = false}
        };
        // GET: Movie
        public ActionResult Index()
        {
            return View(movies);
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View(new MovieModel());
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(MovieModel movieModel)
        {
            movieModel.MovieId = movies.Count + 1;
            movies.Add(movieModel);
            return RedirectToAction("Index");
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
