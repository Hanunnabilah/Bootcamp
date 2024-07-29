using System.Diagnostics;

class Program
{
	static void Main()
	{
		Console.WriteLine("Company Starting");
		Thread employee1 = new Thread(Task);
		employee1.Start();
		employee1.Join();

		Console.WriteLine("Company Stoped");
	}
	static void Task()
	{	
		try
		{
			throw new Exception("Employee Task");
		}
		catch
		{
			Console.WriteLine("Clear Task");
		}
	}
}