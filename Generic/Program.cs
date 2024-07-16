class Collection<T> // using <T> for generic
{
	public T[] myCollection = new T[3]; // using with length 3 data dalam T array
	// variable count = 0;
	// can use constructor for declair lenght
	public Collection(int size)
	{
		myCollection = new T[size];
	}
	public int count = 0;
	// method for add nilai
	public void Add(T input)
	{
		if(count == myCollection.Length)
		{
			return;
		}
		myCollection[count] = input;
		count++;
	}	
	// method for input nilai 
	public T Get(int index)
	{
		return myCollection[index];
	}
	// method for remove data in array
	public void Remove(int index)
	{
		// remove myCollection berdasarkan index dan set menjadi default
		myCollection[index] = default; // default = null atau kosong
	}
}
class Program
{
	static void Main()
	{
		// create a new collection with int type data
		//instantiate generic with Integer
		Collection<int> dataInt = new Collection<int>();
		// add data Integer
		dataInt.Add(3);
		dataInt.Add(4);
		dataInt.Add(5);
		// remove data
		dataInt.Remove(5);
		// print data Interger
		Console.WriteLine("Data Integer : " + dataInt.Get(2));
		//instantiate generic with String
		Collection<string> dataStr = new Collection<string>();
		// add data String
		dataStr.Add("Box");
		dataStr.Add("2Box");
		dataStr.Add("3Box");
		Console.WriteLine("Data String : " + dataStr.Get(2));
	}
}