using Microsoft.EntityFrameworkCore;
using mmd.bo.domain.entity;

public class MmdBoDbContextFactory
{
    internal static string ConnectionString { get{
        return "Host=localhost;Database=mmd;Username=postgres;Password=P@ssw0rd";
    } }
}

public class MmdBoDbContext : DbContext
{
    public MmdBoDbContext(DbContextOptions options):base(options){

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
           optionsBuilder.UseNpgsql(MmdBoDbContextFactory.ConnectionString);
        }
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        #region MenuItem
        // modelBuilder.Entity<MenuItem>().HasKey(mi=>mi.Id); // PRIMARY KEY
        #endregion
    }

    public DbSet<MenuItem> MenuItems { get; set; }
}