using System.Globalization;

// value in enum unchangeable
// craete class enum of Season, which is season unchangeable
public enum ThisSeason
{
	// write the season and insert the value
	Summer,		
	Winter,
	Spring,
	Fall
}
class SeasonChecker
{
	public void Check(ThisSeason season)
	{
		if (season == ThisSeason.Summer)
		{
			Console.WriteLine("July to August");
		}
		else if (season == ThisSeason.Winter)
		{
			Console.WriteLine("September to November");
		}
		else if (season == ThisSeason.Spring)
		{
			Console.WriteLine("December to January");
		}
		else if (season == ThisSeason.Fall)
		{
			Console.WriteLine("February to Maret");
		}
		else
		{
			Console.WriteLine("Can't find the Season");
		}
	}
}
// create class enum of Days in a week
public enum Days
{
	// write the days and value
	Sun = 1,
	Mon,
	Tue,
	Wed,
	Thu,
	Fri,
	Sat
}
class Program
{
	static void Main()
	{
		// create object for seasonChecker
		SeasonChecker seasonChecker = new();
		// print thisSeason 
		ThisSeason thisSeason = ThisSeason.Fall ;
		// unboxing class enum using object
		string StartSeason = ThisSeason.Fall.ToString();
		Console.WriteLine(StartSeason);
		seasonChecker.Check(thisSeason);
		
		// unboxing class enum days to int
		int DaysOfWeek = (int) Days.Tue;
		// search day of 2 in a week?
		Days resultDay = (Days)2; 
		Console.WriteLine(DaysOfWeek);
		Console.WriteLine(resultDay);		
	}
}