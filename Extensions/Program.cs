class Program 
{
	static void Main()
	{
		string a = "Good Morning";
		a.Cetak();
		int x = 24;
		x.Cetak();
		float[] myFloat = {1f,1f,1f,1f,1f};
		myFloat.Cetak();
	}
}
public static class myExtensions
{
	public static void Cetak(this object value)
	{
		Console.WriteLine(value);
	}
}