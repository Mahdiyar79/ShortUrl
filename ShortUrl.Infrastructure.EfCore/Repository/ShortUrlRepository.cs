using System;
using System.Linq;
using System.Linq.Expressions;
using ShortUrl.Domain.ShortUrlAggrigation;

namespace ShortUrl.Infrastructure.EfCore.Repository
{
    public class ShortUrlRepository : IShortUrlRepository
    {
        private readonly ShortUrlContext _context;
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
