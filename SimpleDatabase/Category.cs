using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleDatabase;

public class Category
{
	public int CategoryId { get; set; }
	
	public string CategoryName { get; set; }
	
	public string Description { get; set; }

	public string Picture { get; set; }
}
