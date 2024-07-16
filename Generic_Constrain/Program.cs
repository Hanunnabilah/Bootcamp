using System.Numerics;
using System.Security.Cryptography;

class Person : IAdditionOperators<Person,Person,Person>
{
	public int age = 1; // deklarasi nilai age
	public string name = "My name";
	// Create overloading for operator +
	public static Person operator+(Person a, Person b) 
	{
		int result = a.age + b.age;
		Person human = new Person();
		human.age = result;
		return human;
	}
	public static Person operator*(Person a, Person b)
	{
		int result = a.age * b.age;
		Person human = new Person();
		human.age = result;
		return human;
	}
	// public static Person operator ++ (Person a, Person b)
	// {
	// 	string result = a.name + b.name;
	// 	Person humanName = new Person();
	// 	humanName.age = result;
	// 	return humanName;
	// }
}
class Body<T> Add(T a, T b) where T : IAdditionOperators <T,T,T>
{
		return a + b;
}
class Progam 
{
	static void Main()
	{
		Person human = new Person();
		Person human2 = new Person();
		Person result = human + human2;
		Person result2 = human * human2;
		
		Console.WriteLine(result.age);
		Console.WriteLine(result2.age);
		// Console.WriteLine(result.name);
	}
}