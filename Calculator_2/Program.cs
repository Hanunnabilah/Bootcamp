// Calculator generic using interface
using System.Numerics;

class Calculator
{
	public T Add<T> (T a, T b) where T : IAdditionOperators <T, T, T>
	{
		return a + b;
	}	
	public T Multiply <T>(T a, T b) where T : IMultiplyOperators <T, T, T>
	{
		return a * b;
	}	
	public T Substruction <T>(T a, T b) where T : ISubtractionOperators <T, T, T>	
	{
		return a - b;
	}
}
class Program
{
	static void Main()
	{
		// create instance for Calculator
		Calculator myCalc = new();
		myCalc.Add<int>(1, 2);
		myCalc.Add<float>(1.0f, 2.2f);
		myCalc.Add<decimal>(1.1M, 2.2M);
		myCalc.Add<double>(1.1, 2.2);
		myCalc.Multiply<int>(1, 2);
		myCalc.Multiply<float>(1.0f, 2.2f);
		myCalc.Multiply<decimal>(1.1M, 2.2M);
		myCalc.Multiply<double>(1.1, 2.2);
		myCalc.Substruction<int>(1, 2);
		myCalc.Substruction<float>(1.0f, 2.2f);
		myCalc.Substruction<decimal>(1.1M, 2.2M);
		myCalc.Substruction<double>(1.1, 2.2);
		
		Console.WriteLine(myCalc.Add(1, 2));
		Console.WriteLine(myCalc.Multiply(1, 2));
		Console.WriteLine(myCalc.Substruction(2, 2));
	}
}