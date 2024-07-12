// Interface = contract
interface IParent
{
	void Work(); // interface method (tidak memiliki body)
	void Rest();
}
interface IGrandMa
{
	void Clean();
	// int a; --> dalam interface tidak bisa langsung deklarasi field seperti ini
	// public int x; --> tidak bisa deklarasi field seperti ini
	void Add(int a, int b); // deklarasi field di interface harus seperti ini
}
class ParentKandung
{
	
}
// Child implementasi interface IParent
class Daughter : ParentKandung, IParent // child DAUGHTER dapat menggunakan 2 parent
										// asalkan parent non interface didahulukan
{
	public void Work()
	{
		// the body of Work() is provided here
		Console.WriteLine("Good Morning, it's time to go to work!");
	}
	public void Rest()
	{
		// the body of Rest() is provided here
		Console.WriteLine("Welcome Home, let's take a rest!");
	}
}
class Child : IParent, IGrandMa
{
	public void Work()
	{
		// the body of Work() is provided here
		Console.WriteLine("Good Morning, it's time to go to work!");
	}
	public void Rest()
	{
		// the body of Rest() is provided here
		Console.WriteLine("Welcome Home, let's take a rest!");
	}
	public void Clean()
	{
		Console.WriteLine("Clean home");
	}
	public void Add(int a, int b)
	{
		Console.WriteLine($"Sum of {a} and {b} is {a - b}");
	}
}
class Son : IGrandMa
{
	public void Clean()
	{
		Console.WriteLine("Clean home");
	}
	public void Add(int a, int b)
	{
		Console.WriteLine($"Sum of {a} and {b} is {a - b}");
	}
}
class Program
{
	static void Main()
	{
		Child kids = new Child(); // create object of child
		kids.Work();
		kids.Rest();
		kids.Clean();
		kids.Add(1, 1);
		// Child daughter = new IParent(); --> ERROR, parent tidak bisa dimasukkan dalam child
		IParent parent = new Child();
		// IParent mom = new IParent(); --> ERROR, interface tidak bisa membuat instances for IParent 
		parent.Work();
		parent.Rest();
		// parent.Clean(); --> ERROR, clean tidak ada di IParent
	}
}