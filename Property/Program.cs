class Item
{
	private int _itemCode; //variable dari Hp
	public string name;
	// get accessor for price
	public int GetItemCode()
	{
		return _itemCode;
	}
	// set accessor for price
	private void SetItemCode(int itemCode) // using constractor for inisialisasi property
	{
		this._itemCode = itemCode;
	}
	// get accessor for name
	public string GetName()
	{
		return name;
	}
	// set accessor for name
	private void SetName(string name) // using constractor for inisialisasi property
	{
		this.name = name;
	}
}
// Property
class HpProperty 
{
	public int ItemCode { get; set; } // harus public
	public string Name { get; private set; } // jika di setting private set, maka Name tidak bisa diubah
											// di class program 
}
class Program 
{
	static void Main()
	{
		HpProperty hp= new HpProperty(); // buat objek didalam class HpProperty
		// Settin value for price
		hp.ItemCode = 1000;
		// setting value for name
		hp.Name = "Iphone";
		Console.WriteLine($"Name : {hp.Name}");
		Console.WriteLine($"Item Code : {hp.ItemCode}");
	}	
}