namespace Composition;

public class Tepung
{
	public string brand;
	public int quantity;
	public string type;
	
	public Tepung(string brand, int jumlah, string jenis)
	{
		this.brand = brand;
		this.quantity = jumlah;
		this.type = jenis;
	}
}
