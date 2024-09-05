namespace feature_flag_manager_backend.Data;

using feature_flag_manager_backend.Data.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<FeatureFlag> FeatureFlags { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
}