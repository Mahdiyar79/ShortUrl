using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShortUrl.Application;
using ShortUrl.Application.Contracts.ShortUrl;
using ShortUrl.Domain.ShortUrlAggrigation;
using ShortUrl.Infrastructure.EfCore;
using ShortUrl.Infrastructure.EfCore.Repository;

namespace ShortUrl.Configuration
{
    public class ShortUrlBoostrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IShortUrlApplication, ShortUrlApplication>();
            services.AddTransient<IShortUrlRepository, ShortUrlRepository>();

            services.AddDbContext<ShortUrlContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
