﻿using System.Text;
class Program 
{
	static void Main() {
		StringBuilder Hello = new("Hello");
		int iteration = 100;
		
		for(int i = 0;i < iteration;i++) 
		{
			Hello.Append("A");
			Hello.Append("!");
			Hello.Replace("e", "c");
			Thread.Sleep(2);
		}
	} 
}