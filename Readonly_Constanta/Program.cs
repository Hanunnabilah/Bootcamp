class Cake
{
	public int qty;
	public readonly int cakeCode;
	// crate constructor for Cake
	public Cake(int cakeCode) 
	{
		this.cakeCode = cakeCode;
	}
	// create constanta and give the value unchangeable
	public const int price = 5_000;
}
class Program
{
	static void Main()
	{
		// create object for cake
		Cake myCake = new(1011011);
		// print qty of cake
		myCake.qty = 20;
		// print readOnly for object cake
		// myCake.cakeCode();
		// panggil dengan nama objek yang telah dibuat
		Console.WriteLine($"Code for cake : {myCake.cakeCode}");
		// print Constanta using class Cake
		// Cake.price;
		// panggil dengan nama class Cake
		Console.WriteLine($"Price of cake : {Cake.price}");
	}
}