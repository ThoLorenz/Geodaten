using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Geodaten.WebAPI.Models;
using Geodaten.WebAPI.Data;
using System.Runtime.CompilerServices;

using Microsoft.Extensions.Configuration;
using Geodaten.Service.UrlService;
using System.Net.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Geodaten.WebAPI.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class OpenStreetMapController : Controller
        {

        private readonly Geodaten_Context _context;
        private readonly IConfiguration _configuration;
        private readonly IOpenStreetMapUrlService _openStreetMapUrlService;


        public OpenStreetMapController(Geodaten_Context context, IOpenStreetMapUrlService openStreetMapUrlService, IConfiguration configuration)
            {
            _context = context;
            _openStreetMapUrlService = openStreetMapUrlService;
            _configuration = configuration;
            }

        [HttpGet]
        public async Task<string> GetDocument()
            {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(_configuration.GetValue<string>("OpenStreetMapInitialUrls:Elements"));
            var pageContents = await response.Content.ReadAsStringAsync();
            return pageContents;
            }

        [HttpGet("{id}")]
        public ActionResult<OpenStreetMap> Index(int id)
            {

            var item = _context.OpenStreetMap.Where(x => x.Id == id).FirstOrDefault();
            if (item == null)
                {
                return NotFound();
                }
            return item;
            }
        }
    }
