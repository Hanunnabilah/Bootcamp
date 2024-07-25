// Generation Check using LOH
class Program
{
	static void Main()
	{
		float[] myFloat = new float[100*1024]; //400KB
		Console.WriteLine(GC.GetGeneration(myFloat));
	}
}