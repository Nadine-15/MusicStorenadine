using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using MusicStorenadine.Models;

namespace MusicStorenadine.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return Ok("hello world from Store.Index");
        }
        public IActionResult Browse(string category)
        {
            category = HttpUtility.HtmlEncode("Store.Browse, category =" + category);

            return View();
        }
        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Albums()
        {
            var albums = new List<Album>();

            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album {Name = "Album" + i.ToString() });
            }
                return View(albums);
        }
    }
}