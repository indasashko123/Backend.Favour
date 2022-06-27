using Favour.Core.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Favour.Persistance.EntityTypeConfiguration
{
    internal class AccountTypeConfigration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id).IsUnique();
            builder.Property(x => x.Name).HasMaxLength(25);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Role).IsRequired();
        }
    }
}
