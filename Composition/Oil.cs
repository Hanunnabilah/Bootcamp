namespace Composition;

public class Oil
{
	public string brand;
	public int quantity;
	public string type;
	
	public Oil(string brand, int jumlah, string jenis)
	{
		this.brand = brand;
		this.quantity = jumlah;
		this.type = jenis;
	}
}
