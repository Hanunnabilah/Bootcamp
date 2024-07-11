//PRIVATE

class Person
{
	public string name;
	private string _address;
	private void Work() //hanya bisa diakses oleh person 
	{
		Console.WriteLine("Person Work");
	} 
	public Person(string address)
	{
		this._address = address;
	}
}
class Person2 : Person
{
	public int high;
	public void Rest()
	{
		Console.WriteLine("Person Rest");
	}
	public Person2(string name, int high) : base(name)
	
	{
		this.name = name;
		this.high = high;
	}
}
class Program
{
	static void Main()
	{
		Person person= new Person("Surabaya");
		person.name="Nun";
		// person.address=""; --> error, private variable
		// person.Work(); --> error, function tidak dapat diakses oleh program (PRIVATE)
		// person.Rest(); --> error, person tidak memiliki function Rest
		Console.WriteLine(person.name);
		// Console.WriteLine(person.address);
		
		Person2 human = new Person2("Han", 190);
		// human.name="Han";
		// human.address=""; --> error, private variable
		// human.high=190;
		human.Rest();
		Console.WriteLine(human.name);
		Console.WriteLine(human.high);
		// human.Work(); --> error, function work = private
	}
}