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
            new MovieModel(){MovieId = 1, Name = "Pulp Fiction", Description = "Najlepszy film", Genre = "Comedy", Watched = false},
            new MovieModel(){MovieId = 2, Name = "Breaking Bad", Description = "Najlepszy serial", Genre = "Comedy", Watched = false}
        };
        // GET: Movie
        public ActionResult Index()
        {
            return View(movies);
        }

        public ActionResult Contact()
        {
            return View();
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            return View(movies.FirstOrDefault(x => x.MovieId == id));
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
            return View(movies.FirstOrDefault(x => x.MovieId == id));
        }

        // POST: Movie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MovieModel movieModel)
        {
            MovieModel movie = movies.FirstOrDefault(x => x.MovieId == id);
            movie.Name = movieModel.Name;
            movie.Description = movieModel.Description;
            movie.Genre = movieModel.Genre;
            movie.Watched = movieModel.Watched;
            return RedirectToAction("Index");
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            return View(movies.FirstOrDefault(x => x.MovieId == id));
        }

        // POST: Movie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, MovieModel movieModel)
        {
            MovieModel movie = movies.FirstOrDefault(x => x.MovieId == id);
            movies.Remove(movie);
            return RedirectToAction("Index");
        }
    }
}
