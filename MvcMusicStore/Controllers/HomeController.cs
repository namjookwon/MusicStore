using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        private MusicStoreDB storeDB = new MusicStoreDB();

        [AllowAnonymous]
        public ActionResult Index()
        {
            var albums = storeDB.Albums.OrderBy(a => a.AlbumId).Take(6);
            return View(albums.ToList());
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}