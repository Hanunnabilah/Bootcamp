using System.Diagnostics;

class A()
{
	~A () {}
}
class B()
{
	~B () {}
}
class C()
{
	~C () {}
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
			A a = new A();
			B b = new B();
			C c = new C();
		}	
		stopWatch.Stop();
		Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
	}
}