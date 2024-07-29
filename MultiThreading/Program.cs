// ASYNCHRONOUS (PROGRAM DIJALANKAN BERSAMAAN)
class Program
{
	static void Main()
	{
		Console.WriteLine("Program Start Execution");
		Thread t1 = new Thread(Print); // parameter = method Print karena delegate	
		Thread t2 = new Thread(Fax);
		Thread t3 = new Thread(Scan);
				
		// Start untuk menjalankan program Thread yang dibuat diatas
		t1.Start();
		t2.Start();
		t3.Start();
				
		// Join for Block Main Thread until thread1 completes its execution
		t1.Join();
		t2.Join();
		t3.Join();
		// Console.WriteLine("Thread Status  = {0}", Thread.isAlive);
		Console.WriteLine("Program Finished Execution");
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
