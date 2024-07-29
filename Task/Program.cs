class Program
{
	static void Main()
	{
		Console.WriteLine("Company Starting");
		Task t1 = new Task(Print);
		Task t2 = new Task(Fax);	
		Task t3 = new Task(Scan);
		
		t1.Start();
		t2.Start();
		t3.Start();

		t1.Wait();
		t1.Wait();
		t1.Wait();
		Console.WriteLine("Program End");
	}
	static void Print()
	{
		Console.WriteLine("Print Start");
		Thread.Sleep(1000);
		Console.WriteLine("Print Finished");
	}
	static void Fax()
	{
		Console.WriteLine("Fax Start");
		Thread.Sleep(4000);
		Console.WriteLine("Fax Finished");
	}
	static void Scan()
	{
		Console.WriteLine("Scan Start");
		Thread.Sleep(11000);
		Console.WriteLine("Scan Finished");
	}
}	