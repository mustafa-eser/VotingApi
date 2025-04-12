using Microsoft.EntityFrameworkCore;
using VotingApi.Entities;

namespace VotingApi.Data
{
    public class BracketDbContext : DbContext
    {
        public BracketDbContext(DbContextOptions<BracketDbContext> options) : base(options)
        {
        }

        public DbSet<Bracket> Brackets { get; set; }
    }
}
