using Microsoft.EntityFrameworkCore;
using RentCarProject.Domain.Entities.Models;

namespace RentCarProject_Application.Data
{
    public class RentCarDBContext : DbContext
    {
        public RentCarDBContext(DbContextOptions<RentCarDBContext> options):base(options)
        {
            
        }

        public DbSet<Car> cars { get; set; }
        public DbSet<Lessor> lessor { get; set; }   
        public DbSet<Renter> renter { get; set; }   
    }
}
