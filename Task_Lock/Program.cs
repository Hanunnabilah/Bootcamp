﻿using System.Threading.Tasks.Dataflow;

class Program
{
	static int Counter = 0;
	static object myLock = new();
	static async Task Main()
	{
		Console.WriteLine("Main method started");
		Task task1 = Task.Run(Incrementer);
		Task task2 = Task.Run(Incrementer);
		await Task.WhenAll(task1, task2);
		Console.WriteLine("Main method completed");
	}
	static async Task Incrementer()
	{
		for(int i = 0; i<100 ; i++)
		{
			lock(myLock)
			{
				Counter++;
				Console.WriteLine(Counter);
			}
			await Task.Delay(50);
		}
	}
}