using System.Runtime.CompilerServices;

class Invoice 
{
	public object Add(object a, object b)
	{
		if(a is int && b is int)
		{
			return (int)a + (int)b; 
		} 
		if(a is string && b is string)
		{
			return (string)a + (string)b;
		}
		return null; // kosong
	}
	public object Multiply(object a, object b)
	{
		return (int)a * (int)b; // proses unboxing type data 
	}
	
}
class Program
{
	static void Main()
	{
		int a= 10;
		int b = 1;
		Invoice invoice= new Invoice(); 
		invoice.Add(a,b); // proses boxing --> memasukkan data 
	}
}