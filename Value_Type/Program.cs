class Handphone
{
	public int price;
}
class Program
{
	static void Main()
	{
		int price = 50;
		int sale = 10;
		int newprice = price-sale;
		Console.WriteLine($"Handphoe Price = {price}");
		Console.WriteLine($"Handphone Price After Sale = {newprice}");
	}
}