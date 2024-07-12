abstract class Handphone 
{
	public string type;
	public abstract void Greating(); //wajib diisi oleh child
	public void System()
	{
		Console.WriteLine("System in on");
	}
}
class Machine : Handphone
{
	public override void Greating()
	{
		Console.WriteLine("HELLO");
	}
}
class Program 
{
	static void Main()
	{
		Machine myMachine = new Machine();
		Console.WriteLine(myMachine.type);
	}
}