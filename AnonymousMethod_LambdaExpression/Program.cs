// digunakan untuk proses pemrograman yang singkat
class Program 
{
	static void Main() {
		// var bisa diganti dengan Func<int, int, int>
		// panggil function Add
		// => a+b is return dari class Adder
		var add = (int a, int b) => a+b; // => is arrow function 
		int result = add(3,4); // print result
		Console.WriteLine(result);
	}
}
class Adder
 {
	public int Add(int a,int b) 
	{
		return a + b;
	}
}