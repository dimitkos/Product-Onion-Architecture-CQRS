using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
