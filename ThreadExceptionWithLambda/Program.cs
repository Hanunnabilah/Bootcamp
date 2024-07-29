//ThreadExceptionWithLambda
class Program
{
	static void Main()
	{
		Console.WriteLine("Company Starting");
		Thread employee1 = new Thread(() => {
			try
			{
			MethodA();
			}
			catch(Exception e)
			{
			
			}
		});
		employee1.Start();
		employee1.Join();

		Console.WriteLine("Company Stoped");
	}
	static void MethodA()
	{
		throw new Exception("Employee Task");
	}
}