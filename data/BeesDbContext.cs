using Microsoft.EntityFrameworkCore;
 

public class BeesDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=BeesDatabase.db");
    }
}