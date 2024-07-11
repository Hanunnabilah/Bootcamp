class Animal
{
	public string name;
	public int age;
	public void Eat()
	{
		Console.WriteLine("Eat");
	}
	// virtual method	
	public virtual void MakeSound() // virtual --> parent give pemission for child change sound
	{
		Console.WriteLine(".....");		
	}
}
class Dog : Animal 
{
	public override void MakeSound() // override --> child get permission from parent to change sound
	{
		Console.WriteLine("DOGOOO");
	}
}
class Ant : Animal{}
class Program
{
	static void Main()
	{
		Animal animal= new();
		animal.MakeSound();
		Dog dog = new();
		dog.MakeSound();
		Ant ant = new();
		ant.MakeSound();
	}
}