using System.Security.Principal;

class Calculator
{
	// method for overloading --> kesamaan 'Add' pada setiap fanction dengan implementasi yang berbeda
	// nama method = Add
	// tidak bisa mendeklarasikan dengan parameter yang sama
	public int Add(int a, int b)
	{
		int sum = a+b;
		return sum;
	}
	public float Add(float aa, float ab, float ac) // isi parameter float harus beda dengan isi parameter int sebelumnya
	{
		float sum = aa+ab+ac;
		return sum;
	}
	public string Add(string ba, string bb, string bc, string bd)
	{
		string sum = ba+bb+bc+bd;
		return sum;
	}
}
class Program
{
	static void Main()
	{
		Calculator calculator= new Calculator();
		int a = 1;
		int b = 1;
		int result = calculator.Add(a, b);
		Console.WriteLine(result);
		
		Calculator calculator2= new Calculator();
		float aa = 1;
		float ab = 1;
		float ac = 1;
		float aresult = calculator2.Add(aa, ab, ac);
		Console.WriteLine(aresult);
		
		Calculator calculator3 = new Calculator();
		string ba = "1";
		string bb = "1";
		string bc = "1";
		string bd = "1";
		string bresult = calculator3.Add(ba, bb, bc, bd);
		Console.WriteLine(bresult);	
	}
}