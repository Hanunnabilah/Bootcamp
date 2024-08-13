using Microsoft.EntityFrameworkCore;
namespace SimpleDatabase;

public class MyDatabase : DbContext
{
	public DbSet<Product> Products { get; set; }	
	public DbSet<Category> Categories { get; set; }
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		// optionsBuilder.UseSqlite("Data Source=./MyDatabase.db");
		optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=apapun;Username=postgres;Password=postgres");
	}
}
