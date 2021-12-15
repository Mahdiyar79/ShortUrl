using System;
using System.Linq;
using System.Linq.Expressions;
using ShortUrl.Domain.ShortUrlAggrigation;

namespace ShortUrl.Infrastructure.EfCore.Repository
{
    public class ShortUrlRepository : IShortUrlRepository
    {
        private readonly ShortUrlContext _context;

        public ShortUrlRepository(ShortUrlContext context)
        {
            _context = context;
        }

        public void Update(string shorturl)
        {
           var res= _context.ShortUrls.Where(a => a.ShorterUrl.ToString() == shorturl).FirstOrDefault();
           if (res != null)
           {
               res.VisitCount++;
               _context.Update(res);
            }
            _context.SaveChanges();
        }

        public ShortUrl.Domain.ShortUrlAggrigation.ShortUrl GetBy(string shorturl)
        {
           var res= _context.ShortUrls.Where(a => a.ShorterUrl.ToString() == shorturl).FirstOrDefault();
           return res;
        }

        public void CreateShortUrl(Domain.ShortUrlAggrigation.ShortUrl entity)
        {
            _context.Add(entity);
        }

        public bool Exists(Expression<Func<Domain.ShortUrlAggrigation.ShortUrl, bool>> expression)
        {
            return _context.Set<Domain.ShortUrlAggrigation.ShortUrl>().Any(expression);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
