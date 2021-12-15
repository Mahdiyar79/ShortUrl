using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShortUrl.Infrastructure.EfCore.Mapping
{
    public class ShortUrlMapping : IEntityTypeConfiguration<ShortUrl.Domain.ShortUrlAggrigation.ShortUrl>
    {
        public void Configure(EntityTypeBuilder<ShortUrl.Domain.ShortUrlAggrigation.ShortUrl> builder)
        {
            builder.ToTable("ShortUrls");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ShorterUrl).IsRequired();
            builder.Property(x => x.OrginalUrl).IsRequired();
            builder.Property(x => x.VisitCount).IsRequired();
        }
    }
}
