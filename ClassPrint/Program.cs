using System.Runtime.CompilerServices;

class Program
{
	static void Main()
	{
		Car car = new();
		car.name = "Hyundai";
		Console.WriteLine(car);
	}
}
class Car
{
	public string name;
    public override string ToString() // this is override from parent class object
    {
        return name;
    }
}