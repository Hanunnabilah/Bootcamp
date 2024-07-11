using System.Runtime.InteropServices.Marshalling;

class Animal // class parent
{
	public int age;
	public string gender;
	public string name;
	public string ras;
	
	public void Eat() {}
	public void Poop() {}
	
	// constructor for animal
	public Animal(int age, string gender, string name, string ras)
	{
		this.age = age;
		this.gender = gender;
		this.name = name;
		this.ras = ras;
		Console.WriteLine("Animal Created");
	}
	public Animal(){}
}
class Cat : Animal //tanda : --> dog adalah child dari parent animal
{
	public string moustache;
	public void Play() {}
	// constructor for cat
	public Cat(int age, string gender, string name, string ras,string kumis)
	{
		this.moustache = kumis;
		Console.WriteLine("Cat Created");
	}
}
class Dog : Animal //tanda : --> dog adalah child dari parent animal
{
	public string moustache;
	public void Play() {}
	// constructor for dog
	public Dog(int age, string gender, string name, string ras, string kumis)
	{
		this.moustache = kumis;
		Console.WriteLine("Dog Created");
	}
}
class Program
{
	static void Main()
	{
		Cat cat = new Cat(2, "Girl", "Kumi", "Anggora", "Panjang") ; // create objek animal
		Console.WriteLine(cat.age);
		Console.WriteLine(cat.gender);
		Console.WriteLine(cat.name);
		Console.WriteLine(cat.ras);
		Console.WriteLine(cat.moustache);
		cat.Eat();
		cat.Poop();
	}
}