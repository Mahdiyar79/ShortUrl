using System;
using System.Linq.Expressions;

namespace ShortUrl.Domain.ShortUrlAggrigation
{
    public interface IShortUrlRepository
    {
        void Update(string shorturl);
        ShortUrl GetBy(string shorturl); 
        void CreateShortUrl(ShortUrl entity);
        bool Exists(Expression<Func<ShortUrl, bool>> expression);
        void SaveChanges();
    }
}
