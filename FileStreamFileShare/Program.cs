﻿class Program
{
	static void Main()
	{
		string path = @".\myFIle.txt";
		using(FileStream fs = new(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
		{
			Console.WriteLine("File opened");
			Console.ReadLine();
		}
	}
}