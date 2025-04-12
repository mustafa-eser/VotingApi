using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using VotingApi.Entities;

namespace VotingApi.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
