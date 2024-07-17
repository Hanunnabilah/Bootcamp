class Program
{
	static void Main()
	{
		// create new object for Dictionary
		Dictionary <int, string> myDictionary = new();
		// add value for myDictionary
		myDictionary.Add(1, "Civil");
		myDictionary.Add(3, "Telecommunication");
		myDictionary.Add(5, "Language");
		myDictionary.Add(7, "Science");
		
		// create result to display myDictionary 1
		string restult = myDictionary[1];
		// string restult = myDictionary[2]; --> error, 2 tidak ditulis dalam myDictionary  
		
		// for check dictionary using Contains
		bool status = myDictionary.ContainsKey(2);
		bool status2 = myDictionary.ContainsValue("Science");
		
		// print output
		Console.WriteLine(restult); 
		Console.WriteLine(status); 
		Console.WriteLine(status2); 
	}
}