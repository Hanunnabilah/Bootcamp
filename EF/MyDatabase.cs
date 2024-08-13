using Microsoft.EntityFrameworkCore;

namespace EF;

public class MyDatabase : DbContext 
{
	private string path = String.Empty;
	public DbSet<Product>? Products { get; set; }
	public DbSet<Category>? Categories { get; set; }
	public DbSet<Employee>? Employees { get; set; }
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		path = Path.Combine(Environment.CurrentDirectory,"Northwind.db");
		string connectionPath = $"Data Source={path}";
		optionsBuilder.UseSqlite(connectionPath);
	}
}
