﻿class Aa 
{
	~Aa() 
	{
		Console.WriteLine("Aa destructor");
	}
}
class Bb : Aa
{
	~Bb() 
	{
		Console.WriteLine("Bb destructor");
	}
}
class Cc : Bb
{
	~Cc() 
    {
        Console.WriteLine("Cc destructor");
    }
}

class Program 
{
	static void Main() 
	{
		InstanceCreator();
		GC.Collect();
		GC.WaitForPendingFinalizers();
	}
	static void InstanceCreator() 
	{
		Cc c = new();
	}
}