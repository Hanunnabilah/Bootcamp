public delegate void myDelegate(); // parameterless	
class Youtuber
{
	public Subscriber subscriber;
	public event myDelegate del; // deklarasi event
	public void ResetSubscriber()
	{
		del = null;
	}
}
class Subscriber
{
	
}

class Program
{
	static void Main()
	{
		Youtuber youtube = new();
		Subscriber sub = new();
		
	}
}
