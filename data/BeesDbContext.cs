using Microsoft.EntityFrameworkCore;
 

public class BeesDbContext : DbContext
{
    public DbSet<Info> Infos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=BeesDatabase.db");
    }
}