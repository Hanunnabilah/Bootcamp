class Calculator
{
	public int Add(int a, int b)
	{
		return a+b;
	}
}
class Program
{
	static void Main()
	{
		Console.WriteLine("Start");
		Calculator calculator = new();
		int result = calculator.Add(5, 5);
		Console.WriteLine(result);
	}
}