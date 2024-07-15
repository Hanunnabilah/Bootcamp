using System.Runtime.CompilerServices;

class Item
{
	public int productionCode;
	public static int count = 0;
	public Item()
	{
		count++;
		productionCode = count;
	}
	public int GetProductionCode()
	{
		return count;
	}
	public static int GetProductionCodes()
	{
		// return productionCode; 
		return count;
	}
	public static void Display()
	{
		Console.WriteLine("Static method");
	}
	public void Display2()
	{
		Console.WriteLine("Non Static method");
	}
}
class Program
{
	static void Main()
	{
		Item clock = new Item();
		Console.WriteLine(clock.productionCode);
		// memanggil dari class Item lansung karna count == static
		Console.WriteLine(Item.count); 
		clock.Display2();
		Item.Display(); // Display --> static
		
		Item box = new Item();
		Console.WriteLine(box.productionCode);
		// memanggil dari class Item lansung karna count == static
		Console.WriteLine(Item.count); 
		// Console.WriteLine(box.count); --> error	
	}
}