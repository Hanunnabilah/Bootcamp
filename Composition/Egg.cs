namespace Composition; //kelas ini menggunakan namespace composition

public class Egg
{
	// hal - hal yang perlu dijelaskan dalam objek egg
	public string type;
	public int quantity;
	
	//consructor for egg
	public Egg(string jenis, int jumlah)
	{
		this.type = jenis; // memasukkan nilai pada variable jenis
		this.quantity = jumlah; // memasukkan nilai pada variable jumlah
	}
}
