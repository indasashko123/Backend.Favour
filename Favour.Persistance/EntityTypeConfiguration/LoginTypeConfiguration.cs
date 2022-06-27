using Favour.Core.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Favour.Persistance.EntityTypeConfiguration
{
    internal class LoginTypeConfiguration : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id).IsUnique();
            builder.Property(x => x.Password).HasMaxLength(15);
            builder.Property(x => x.Email).HasMaxLength(25);
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Password).IsRequired();
        }
    }
}
