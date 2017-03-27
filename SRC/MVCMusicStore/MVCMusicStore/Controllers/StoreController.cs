using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStore.Models;

namespace MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store

       
        public ActionResult Index()
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Disco"},
                new Genre { Name = "Jazz"},
                new Genre { Name = "Rock"}
            };

            return View(genres);   

        }

        //Get: /Store/Browse?genre=Disco
        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { Name = genre };

            return View(genreModel);
          //  string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);

            //return message;

        }

        // Get: /Store/Details
        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album " + id };

            return View(album);
        }
    }
}