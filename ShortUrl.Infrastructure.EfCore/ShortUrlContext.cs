using Microsoft.EntityFrameworkCore;
using ShortUrl.Infrastructure.EfCore.Mapping;

namespace ShortUrl.Infrastructure.EfCore
{
    public class ShortUrlContext : DbContext
    {
        public DbSet<Domain.ShortUrlAggrigation.ShortUrl> ShortUrls { get; set; }

        public ShortUrlContext(DbContextOptions<ShortUrlContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var Assembley = typeof(ShortUrlMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(Assembley);
            base.OnModelCreating(modelBuilder);
        }
    }
}
