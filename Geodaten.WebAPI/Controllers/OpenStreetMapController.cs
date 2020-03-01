using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Geodaten.WebAPI.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Geodaten.WebAPI.Controllers
    {
    public class OpenStreetMapController : Controller
        {
        // GET: /<controller>/
        public IActionResult Index()
            {
            OpenStreetMap osm = new OpenStreetMap();
            osm.Id = 1;
            osm.Name = "test";
            return View(osm);
            }
        }
    }
