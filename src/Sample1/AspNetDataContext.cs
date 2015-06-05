using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Sample1Data;

namespace Sample1
{
    public class AspNetDataContext : IdentityDbContext, IDataContext
    {
        public DbSet<Player> Players { get; set; }
    }
}
