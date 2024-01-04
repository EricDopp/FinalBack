using Final.Models;
using Microsoft.EntityFrameworkCore;

namespace Final.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<WorkoutPlan> WorkoutPlans { get; set; }
    public DbSet<WorkoutSets> WorkoutSets { get; set; }
}