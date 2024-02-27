using Application.Commons.Interfaces;
using Domain.Entities;

namespace Infrastructure.Persistance;

internal class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<Product> Products => Set<Product>();



}
