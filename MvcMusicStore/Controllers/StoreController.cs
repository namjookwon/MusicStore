using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        private MusicStoreDB db = new MusicStoreDB();
        // GET: Store
        public ActionResult Index()
        {
            //var genres = db.Genres.ToList();
            //return View(genres);

            var albums = db.Albums;
            return View(albums.ToList());
        }

        // GET: Store/Browse
        public ActionResult Browse(string genre)
        {
            // Retrieve Genre genre and its Associated associated Albums albums from database
            var genreModel = db.Genres.Include("Albums")
                .Single(g => g.Name == genre);

            return View(genreModel);
        }

        // GET: Store/Details
        public ActionResult Details(int id)
        {
            var album = db.Albums.Find(id);

            return View(album);
        }
    }
}