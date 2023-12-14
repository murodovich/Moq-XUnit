using Microsoft.EntityFrameworkCore;
using Moq_XUnit.Domain.Entities;

namespace Moq_XUnit.Infrastructure.Persistance
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

    }
}
