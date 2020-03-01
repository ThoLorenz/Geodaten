using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Geodaten.Service.UrlService
    {
    public class OpenStreetMapUrlService : IOpenStreetMapUrlService
        {
        public OpenStreetMapUrlService()
            {
            }

        public async Task<string> getDocumentFromUrl(string url)
            {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("http://www.nzherald.co.nz/");
            var pageContents = await response.Content.ReadAsStringAsync();
            return pageContents;
            }
        }
    }
