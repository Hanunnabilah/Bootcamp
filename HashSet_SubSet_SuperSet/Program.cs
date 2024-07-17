class Program
{
	static void Main()
	{
		HashSet<int> A = new() { 1, 2, 3, 4, 5 };
		HashSet<int> B = new() { 1, 2, 3 };

		bool status = A.IsSupersetOf(B);
		Console.WriteLine(status);
		// status.Dump();

		bool status2 = B.IsSubsetOf(A);
		Console.WriteLine(status2);
		// status.Dump();
	}
}
