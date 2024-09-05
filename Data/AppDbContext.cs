namespace feature_flag_manager_backend.Data;

using feature_flag_manager_backend.Data.Models;
using Microsoft.EntityFrameworkCore;

class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<FeatureFlag> FeatureFlags { get; set; }
}