class Handphone // reference type  yang disimpan didalam heap
{
	public int price; // int termasuk dalam struck yang mana akan disimpan didalam stack
	 public Handphone(int price)
	 {
	 	this.price = price;
	 }
}
class Program
{
	static void Main()
	{
		Handphone handphone = new(12);
		Console.WriteLine(handphone.price);
	}
}