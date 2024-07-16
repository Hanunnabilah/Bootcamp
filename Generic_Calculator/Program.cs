using System.Numerics;

class Calculator<T>
// create generic constrain (batasan for generic)
// using interface IAdditionOperators <T Self, T Other, T Result> <T integer a, T integer b, T result a+b>
// where T : IAdditionOperators<T, T, T> // but, this interface cannot use in sustrcution(pengurangan)

// agar bisa digunakan dalam operator lain maka menggunakan INumber<T>
where T : INumber<T>
{
	public T Add(T a, T b)
	{
		return a + b;
	}	
	public T Multiply(T a, T b)
	{
		return a * b;
	}	
}
class Program
{
	static void Main()
	{
		Calculator<int> myCalcInt = new Calculator<int>();
		myCalcInt.Add(1, 2);
		int result = myCalcInt.Add(1, 2);
		Console.WriteLine(result);
		Calculator<double> myCalcStr = new Calculator<double>();
		myCalcStr.Add(2.1, 2.0);
		Calculator<float> myCalcFloat = new Calculator<float>();
		myCalcFloat.Add(1.0f, 2.0f);
		Calculator<decimal> myCalcDec = new Calculator<decimal>();
		myCalcDec.Add(1.1M, 2.1M);
		
	}
}

