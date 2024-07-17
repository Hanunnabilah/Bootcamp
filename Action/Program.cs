class Program
{
	static void Main()
	{
		// Action<T1, T2> for Add
		Action<int, int> display = Add; 
		display.Invoke(1, 4);
	}
	// create method MUST be using return type void
	static void Add(int a, int b)
	{
		Console.WriteLine(a+b);
	}
}