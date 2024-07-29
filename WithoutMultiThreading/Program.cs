// SYNCHRONOUS (PROGRAM DIJALANKAN BERGANTIAN)
class Program
{
	static void Main()
	{
		Console.WriteLine("Program Start Execution");
		Print();
		Fax();
		Scan();
		Console.WriteLine("Program Finshed Execution");
		
	}
	static void Print()
	{
		Console.WriteLine("Print Start");
		// hold program selama 5 detik
		Thread.Sleep(5000);
		Console.WriteLine("Print Finished");
	}
	static void Fax()
	{
		Console.WriteLine("Fax Start");
		// hold program selama 10 detik
		Thread.Sleep(10000);
		Console.WriteLine("Fax Finished");
	}static void Scan()
	{
		Console.WriteLine("Scan Start");
		// hold program selama 3 detik
		Thread.Sleep(3000);
		Console.WriteLine("Scan Finished");
	}
}	