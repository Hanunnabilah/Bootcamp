class Program
{
	static void Main()
	{
		HashSet<int> MyHashSet = new HashSet<int>();
		MyHashSet.Add(3);
		MyHashSet.Add(9);
		MyHashSet.Add(7);
		MyHashSet.Add(3); // ini tidak akan dicetak karena sudah dimasukkan pada list sebelumnya

		Console.WriteLine(MyHashSet);
	}
}
