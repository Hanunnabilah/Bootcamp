using System.Runtime.CompilerServices;
using CalculatorLib;

class Program
{
	static void Main()
	{	
		do
		{
			Calculator calculator = new Calculator();
			// input user from terminal
			//Console readline return string 
			Console.WriteLine("Masukkan angka pertama = ");
			string inputUser = Console.ReadLine();
			Console.WriteLine("Masukkan angka kedua = ");
			string inputUser2 = Console.ReadLine();
			
			int inputUserInt= int.Parse(inputUser);
			int inputUser2Int = int.Parse(inputUser2);
			// int result = calculator.Add(3, 6);
			
			// call output calculator method
			int result = calculator.Add(inputUserInt,inputUser2Int);
			Console.WriteLine("Hasilnya adalah "+ result.ToString());
			Console.WriteLine("Apakah anda ingin menghitung lagi?");
		}
		while (Console.ReadLine().ToLower()=="y");
		;
	}
}