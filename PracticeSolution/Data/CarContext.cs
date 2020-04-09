using Microsoft.EntityFrameworkCore;
using PracticeSolution.Models;

namespace PracticeSolution.Data
{
    public class CarContext: DbContext
    {
        public CarContext(DbContextOptions<CarContext> options)
            : base(options) {}

        public DbSet<Car> Car { get; set; }
    }
}