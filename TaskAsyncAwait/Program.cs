// ASYNCHRONOUS THREAD BLOCKING
class Program
{
	static async Task Main()
	// static void Main()
	{
		Console.WriteLine("Program Start Execution");
		Task t1 = Task.Run(() => Print()); // parameter = method Print karena delegate	
		Task t2 = Task.Run(() => Fax());
		Task t3 = Task.Run(() => Scan());		
		
		await Task.WhenAll(t1, t2, t3);
		// t1.Start(); -->  make thread blocking
		// t2.Start();
		// t3.Start();
				
		Console.WriteLine("Program Finished Execution");
	}
	static async Task Print()
	{
		Console.WriteLine("Print Start");
		// hold program selama 5 detik
		// Thread.Sleep(5000); --> menyebabkan program thread blocking
		await Task.Delay(5000);
		Console.WriteLine("Print Finished");
	}
	static async Task Fax()
	{
		Console.WriteLine("Fax Start");
		// hold program selama 10 detik
		await Task.Delay(5000);
		Console.WriteLine("Fax Finished");
	}static async Task Scan()
	{
		Console.WriteLine("Scan Start");
		// hold program selama 3 detik
		await Task.Delay(5000);
		Console.WriteLine("Scan Finished");
	}
}
