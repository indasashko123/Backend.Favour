using Favour.Core.SocialMedia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Favour.Persistance.EntityTypeConfiguration
{
    internal class LikeTypeConfiguration : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id).IsUnique();
            builder.Property(x => x.IsLike).IsRequired();
            builder.Property(x => x.ContentId).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
        }
    }
}
