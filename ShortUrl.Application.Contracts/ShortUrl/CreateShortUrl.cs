using System;

namespace ShortUrl.Application.Contracts.ShortUrl
{
    public class CreateShortUrl
    {
        public string OrginalUrl { get; set; }
        public Guid ShorterUrl { get; set; }
    }
}
