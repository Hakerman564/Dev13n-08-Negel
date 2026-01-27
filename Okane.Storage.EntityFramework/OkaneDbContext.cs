using Microsoft.EntityFrameworkCore;
using Okane.Application;

namespace Okane.Storage.EntityFramework;

public class OkaneDbContext(DbContextOptions<OkaneDbContext> options) : DbContext(options)
{
    public DbSet<Expense> Expenses => Set<Expense>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder) => 
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(OkaneDbContext).Assembly);
};