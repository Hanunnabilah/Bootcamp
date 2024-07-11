//PUBLIC ENCAPSULATION

public class Car
{
	public int price;
	public string brand;
	
	public void Start()
	{
		Console.WriteLine("Start");
	}
	public void Stop()
	{
		Console.WriteLine("Stop");
	}
}

class Program
{
	static void Main()
	{
		Car car = new Car();
		car.price = 11000;
		car.brand = "Honda";
		car.Start();
		Console.WriteLine(car.price);
		Console.WriteLine(car.brand);
		car.Stop();
	}
}