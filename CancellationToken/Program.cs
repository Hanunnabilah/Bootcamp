class Program
{
	static void Main()
	{
		Console.WriteLine("Check order");
		CancellationTokenSource orderCts = new CancellationTokenSource();
		Task t1 = Task.Run(() => CheckItem());
		Task t2 = Task.Run(() => CheckAddress());
		Task t3 = Task.Run(() => Payment(orderCts.Token));
		Task t5 = Task.Run(() => 
		{
			Thread.Sleep(10000);
			orderCts.Cancel();
		});
		Task.WaitAny(t1,t2);
		Console.ReadLine();
	}
	static void CheckItem()
	{
		Console.WriteLine("Item is selected");
	}
	static void CheckAddress()
	{
		Console.WriteLine("Address is filled");
	}
	static void Payment(CancellationToken ct)
	{
		 while(!ct.IsCancellationRequested)
		 {
		 	Console.WriteLine("Waiting for payment");
		 	Thread.Sleep(1000);
		 }
		 Console.WriteLine("Payment Canceled");
	}
}