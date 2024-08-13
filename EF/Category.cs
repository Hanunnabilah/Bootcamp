	namespace EF;

public class Category
{
	public int CategoryId { get; set; }
	public string CategoryName { get; set; }
	public string Description { get; set; }
	// category have many product
	public IEnumerable<Product> Products { get; set; }
	public Category()
	{
		Products = new HashSet<Product>();
	}
}
