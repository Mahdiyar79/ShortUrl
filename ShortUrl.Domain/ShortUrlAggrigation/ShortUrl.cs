using System;

namespace ShortUrl.Domain.ShortUrlAggrigation
{
    public class ShortUrl
    {
        public long Id { get; set; }
        public string OrginalUrl { get; set; }
        public Guid ShorterUrl { get; set; }
        public long VisitCount { get; set; }
        public ShortUrl(string orginalUrl, Guid shorterUrl)
        {
            OrginalUrl = orginalUrl;
            ShorterUrl = shorterUrl;
        }

        public ShortUrl(long visitCount)
        {
            VisitCount = visitCount;
        }
    }
}
