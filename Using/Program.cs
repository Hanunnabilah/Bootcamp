﻿class Program 
{
	static void Main() 
	{
		string path = "./file.txt";
		using(FileStream fs = new(path, FileMode.Create)) //using is try and finally dispose
		{
			
		} // dispose
	}
}