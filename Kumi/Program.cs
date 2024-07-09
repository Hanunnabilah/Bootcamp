class Cat

{
	//camel case : isAlive --> attribute/variable
	//pascal case : Eat atau Sleep --> function/class
	//variable
	public bool manja;
	public string colour;
	public bool isMale;
	
	//function
	public void Poop ()
	
	{
		Console.WriteLine("Poop");
	}
	
	public void Eat()
	
	{
		Console.WriteLine("Eat");
	}
}

class Program

{
	static void Main()
	
	{
		Cat kumi = new Cat();
		kumi.manja = true;
		kumi.colour = "Brown";
		kumi.isMale = false;
		Console.WriteLine(kumi.manja);
		Console.WriteLine(kumi.colour);
		Console.WriteLine(kumi.isMale);

		kumi.Poop();
		kumi.Eat();

		Cat john = new Cat();
		john.manja = true;
		john.colour = "White";
		john.isMale = true;
		Console.WriteLine(kumi.manja);
		Console.WriteLine(kumi.colour);
		Console.WriteLine(kumi.isMale);
	}
}