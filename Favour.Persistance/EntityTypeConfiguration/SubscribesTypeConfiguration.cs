using Favour.Core.SocialMedia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Favour.Persistance.EntityTypeConfiguration
{
    internal class SubscribesTypeConfiguration : IEntityTypeConfiguration<Subscribes>
    {
        public void Configure(EntityTypeBuilder<Subscribes> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id).IsUnique();
        }
    }
}
