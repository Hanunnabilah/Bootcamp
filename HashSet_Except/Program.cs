//HashSet<T> Union

using System.Runtime.InteropServices;
class Program
{
	static void Main()
	{
	HashSet<int> A = new () {1,2,3,4,5};
	HashSet<int> B = new () {4,5,6,7,8};
	
	A.Except(B);
	Console.WriteLine(A);
	}
}
