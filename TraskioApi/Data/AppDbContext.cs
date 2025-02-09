using Microsoft.EntityFrameworkCore;
using TraskioApi.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Task> Tasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Map all tables to lowercase naming convention
        modelBuilder.Entity<User>().ToTable("users");
        modelBuilder.Entity<Project>().ToTable("projects");
        modelBuilder.Entity<Task>().ToTable("tasks");
    }
}
