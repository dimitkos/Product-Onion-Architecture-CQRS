using Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Application
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }
        Task<int> SaveChanges();
    }
}
