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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Page>().HasData(
                new Page
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Title = "New Products",
                    ImageUrl = "https://placehold.co/300x230",
                    Description = "Lorem ipsum dolor sit amet, id per dictas inermis. Eam odio modo cibo at. Purto dignissim euripidis eu mel, cu mel."
                },
                new Page
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Title = "Field Events",
                    ImageUrl = "https://placehold.co/300x230",
                    Description = "Lorem ipsum dolor sit amet, id per dictas inermis. Eam odio modo cibo at. Purto dignissim euripidis eu mel, cu mel."
                },
                new Page
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Title = "Latest News",
                    ImageUrl = "https://placehold.co/300x230",
                    Description = "Lorem ipsum dolor sit amet, id per dictas inermis. Eam odio modo cibo at. Purto dignissim euripidis eu mel, cu mel."
                },
                new Page
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Title = "Gallery",
                    ImageUrl = "https://placehold.co/300x230",
                    Description = "Lorem ipsum dolor sit amet, id per dictas inermis. Eam odio modo cibo at. Purto dignissim euripidis eu mel, cu mel."
                }
                );
        }
    }
}
