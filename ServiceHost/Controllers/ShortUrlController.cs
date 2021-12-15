using System.Net;
using Microsoft.AspNetCore.Mvc;
using ShortUrl.Application.Contracts.ShortUrl;

namespace ServiceHost.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShortUrlController : ControllerBase
    {

        private readonly IShortUrlApplication _shortUrlApplication;

        public ShortUrlController(IShortUrlApplication shortUrlApplication)
        {
            _shortUrlApplication = shortUrlApplication;
        }

        [HttpGet]
        public IActionResult Get(string shorterurl)
        {
            ShowOrginalUrl orginalUrl = new ShowOrginalUrl()
            {
                ShorterUrl = shorterurl
            };
            var url = _shortUrlApplication.GetOrginalUrl(orginalUrl);
            if (url.IsSuccedded)
                return RedirectToRoute(url.Massage);
            return new ObjectResult(HttpStatusCode.NotFound + "" + url.Massage);
        }
        [HttpPost]
        public IActionResult Create(string orginalurl)
        {
            CreateShortUrl createShortUrl = new CreateShortUrl()
            {
                OrginalUrl = orginalurl
            };
            var result = _shortUrlApplication.Create(createShortUrl);
            return new ObjectResult("{'result':" + "'" + result.Massage + "'" + "}");
        }
    }
}
