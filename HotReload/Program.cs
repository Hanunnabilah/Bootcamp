class Program
{
	static async Task Main()
	{
		while(true)
		{
			Console.WriteLine("horas");
			await Task.Delay(2000);
		}
	}
}