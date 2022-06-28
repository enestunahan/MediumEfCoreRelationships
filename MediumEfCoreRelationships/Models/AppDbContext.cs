using Microsoft.EntityFrameworkCore;

namespace MediumEfCoreRelationships.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
    }
}
