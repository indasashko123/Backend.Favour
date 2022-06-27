using Favour.Core.PersonalConfigure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favour.Persistance.EntityTypeConfiguration
{
    internal class PayConfigTypeConfiguration : IEntityTypeConfiguration<PayConfig>
    {
        public void Configure(EntityTypeBuilder<PayConfig> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id).IsUnique();
        }
    }
}
