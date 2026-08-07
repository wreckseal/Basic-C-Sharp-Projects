using Microsoft.EntityFrameworkCore;
using TechStoreInventory.Models;

namespace TechStoreInventory.Data;

public class InventoryContext(DbContextOptions<InventoryContext> options) : DbContext(options)
{
    public DbSet<Products> Products { get; set; }
}

