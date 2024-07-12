//abstract class
abstract class Animal
{
	public abstract void animalSound(); //tidak diisi function karena abstract
	public abstract void play();
	public void Sleep()
	{
		Console.WriteLine("Zzzzz");
	} 
}
class Monkey : Animal
{
	public override void animalSound()
	{
		Console.WriteLine("The monkey says: Uu Aa");
	}
	public override void play()
	{
		Console.WriteLine("I am happy Uu Aa");
	}
}
class Horse : Animal
{
	public override void animalSound()
	{
		Console.WriteLine("The horse says: Brrr");
	}
	public override void play()
	{
		Console.WriteLine("I am ready for having fun today");
	}
}
class Program
{
	static void Main()
	{
		Monkey myMonkey = new Monkey();
		myMonkey.animalSound();
		Console.WriteLine("Hi i am Monkey");
		myMonkey.play();
		myMonkey.Sleep();
		Horse myHorse = new Horse();
		myHorse.animalSound();
		Console.WriteLine("Hi i am Horse");
		myHorse.play();	
		myHorse.Sleep();
	}
}