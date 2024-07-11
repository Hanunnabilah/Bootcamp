class Father
{
	public string name;
	public virtual void Work()
	{
		Console.WriteLine("Work");
	}
}

class Son : Father
{
	public string age;
	public override void Work()
	{
		Console.WriteLine();
	}
}
class Program
{
	static void Main()
	{
		Father ayah = new Father();
		ayah.Work();
		
		Father ayah2 = new Son();
		ayah2.Work();
		
		Son anak = new Son();
		anak.Work(); 
		
		// Son anak2 = new Father();
		// anak2.Work();
	}
}