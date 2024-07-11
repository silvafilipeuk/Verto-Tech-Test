using Microsoft.EntityFrameworkCore;
using Verto_Tech_Test.Models.Domain;

namespace Verto_Tech_Test.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Page> Pages { get; set; }
    }
}
