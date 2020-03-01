using System.Threading.Tasks;

namespace Geodaten.Service.UrlService
    {
    public interface IOpenStreetMapUrlService
        {

        Task<string> getDocumentFromUrl(string url);
        }
    }