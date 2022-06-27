using Favour.Core.Identity;
using Favour.Core.PersonalConfigure;
using Favour.Core.SocialMedia;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Favour.Application.Interfaces
{
    public interface IFavourContext
    {
        DbSet<Account> Accounts { get; set; }
        DbSet<Login> Logins { get; set; }
        DbSet<AuthorConfig> AuthorConfigs { get; set; }
        DbSet<PayConfig> PayConfigs { get; set; }
        DbSet<Like> Likes { get; set; }
        DbSet<Message> Messages { get; set; }
        DbSet<Subscribes> Subscribes { get; set; }


        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
