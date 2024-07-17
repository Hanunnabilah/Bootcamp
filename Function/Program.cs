class Program
{
	static void Main()
	{
		// function<T1, T2, TreturnType> for Add
		Func<int, int, int> X = Add;
		int result = X.Invoke(1,1);
	}
	// create method using return type int
	static int Add(int a, int b)
	{
		return(a+b);
	}
}