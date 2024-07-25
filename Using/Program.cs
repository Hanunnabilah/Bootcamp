using System.Net.Http.Headers;

class Program
{
	static void Main()
	{
		MyMethod();
	}
	static void MyMethod()
	{
		using(FileStream fs = new FileStream())
		{
		AnotherMethod(fs);
		// fs.Dispose();
		}
	}
	static void AnotherMethod(FileStream fs)
	{
		
	}
}