// Finalizer or Destructor 
class Destructor
{
	public Destructor ()
	{
		Console.WriteLine($"This is Constructor {GC.GetGeneration(this)} created");
	}
	~Destructor ()
	{
		Console.WriteLine($"This is Destructor {GC.GetGeneration(this)} created");
	}
}
class Program
{
	static void Main()
	{
		instanceCreator();
		GC.Collect ();
		GC.WaitForPendingFinalizers ();
	}	
	static void instanceCreator()
	{
		Destructor myDestructor = new Destructor ();
	}
}
