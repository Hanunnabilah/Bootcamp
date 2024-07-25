using System.Diagnostics;

class Aa()
{

}
class Bb()
{
	
}
class Cc()
{

}

class Program
{
	static void Main()
	{
		int iteration = 1_000_000;
		Stopwatch stopWatch = new();
		stopWatch.Start();
		for(int i = 0; i < iteration;i++)
		{
			Aa a = new Aa();
			Bb b = new Bb();
			Cc c = new Cc();
		}	
		stopWatch.Stop();
		Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
	}
}