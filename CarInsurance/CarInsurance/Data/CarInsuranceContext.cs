using CarInsurance.Models;
using Microsoft.EntityFrameworkCore;

namespace CarInsurance.Data
{
    public class CarInsuranceContext(DbContextOptions<CarInsuranceContext> options) : DbContext(options)
    {
        public DbSet<Insurees> Insurees { get; set; }
    }
}
