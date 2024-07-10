using CakeComposition; //menggunakan program dengan namespace cakecomposition
using Composition; //menggunakan 

class Program
{
	static void Main()
	{
		Tepung tepung = new Tepung("Rose Brand", 1 , "Terigu");
		Oil oil = new Oil("Bimoli", 100 , "Minyak Goreng");
		Egg egg = new Egg("Telur Ayam", 10);
		Cake cake = new Cake(tepung, oil, egg);
		
		Console.WriteLine("---THESE ARE COMPOSITIONS OF CAKE---");
		Console.WriteLine("1. Flour");
		Console.WriteLine("Brand : " + cake.flour.brand);
		Console.WriteLine("Quantity : " + cake.flour.quantity + " kg");
		Console.WriteLine("Type : " + cake.flour.type);
		Console.WriteLine("2. Oil");
		Console.WriteLine("Brand : " + cake.oil.brand);
		Console.WriteLine("Berat : " + cake.oil.quantity + " gram");
		Console.WriteLine("Type : " + cake.oil.type);
		Console.WriteLine("3. Egg");
		Console.WriteLine("Type : " + cake.egg.type);
		Console.WriteLine("Quantity : " + cake.egg.quantity);
	}
}