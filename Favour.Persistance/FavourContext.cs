using Favour.Application.Interfaces;
using Favour.Core.Identity;
using Favour.Core.PersonalConfigure;
using Favour.Core.SocialMedia;
using Favour.Persistance.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Favour.Persistance
{
    public class FavourContext : DbContext, IFavourContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AuthorConfig> AuthorConfigs { get; set; }
        public DbSet<PayConfig> PayConfigs { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Subscribes> Subscribes { get; set; }



        public FavourContext (DbContextOptions<FavourContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AccountTypeConfigration());
            builder.ApplyConfiguration(new LoginTypeConfiguration());
            builder.ApplyConfiguration(new AuthorConfigTypeConfiguration());
            builder.ApplyConfiguration(new PayConfigTypeConfiguration());
            builder.ApplyConfiguration(new LikeTypeConfiguration());
            builder.ApplyConfiguration(new MessageTypeConfiguration());




            base.OnModelCreating(builder);
            
        }
    }
}
