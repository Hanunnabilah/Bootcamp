using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleDatabase;

public class Product
{
	public int ProductId { get; set; }
	
	public string ProductName { get; set; }
	
	public int SupplierId { get; set; }
	public int CategoryId { get; set; }
	public string QuantityPerUnit {get; set; }
	
	public int UnitPrice { get; set; }
	
	public int UnitsInStock { get; set; }
	
	public int ReorderLevel { get; set; }
	
	// [Column(TypeName = "bit")]
	public int Discontinued { get; set; }
	
}
