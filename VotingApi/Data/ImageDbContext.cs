using Microsoft.EntityFrameworkCore;
using VotingApi.Entities;

namespace VotingApi.Data
{
    public class ImageDbContext : DbContext
    {

        public ImageDbContext(DbContextOptions<ImageDbContext> options) : base(options)
        {
        }

        public DbSet<Image> Images { get; set; }
    }
}
