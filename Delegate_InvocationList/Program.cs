using System.ComponentModel;

// Create a method for a delegate 
public delegate void MyDelegate();
// create class publisher
public class Publisher
{
	// create delegasi for _del(use _ when private)
	private MyDelegate _subs;
	// create a list for Mydelegate, save in new object named historySubs
	private List<MyDelegate> _historySubs = new();
	// create new method for add subscribers
	public bool AddSub(MyDelegate del) //parameter use method del
	{
		if (!(CheckDelegate(del))) // jika tidak ada checkdelegate(del)
		{
			_subs += del; // maka subscriber ditambahkan
			_historySubs.Add(del); // subscriber ditambahkan didalam history
			return true; // nilai dikembalikan dengan true
		}
		return false; // jika tidak maka nilai dikembalikan dengan false

	}
	//  create new method for remove subscribers
	public bool RemoveSub(MyDelegate del)
	{
		if(CheckDelegate(del))
		{
			_subs -= del; //maka subscribers dihapus atau dikurangi
			return true; // nilai dikemabalikan dengan true
		} 
		return false;
	}
	// create method for checkDelegate dalam del
	public bool CheckDelegate(MyDelegate del)
	{
		if(_subs is not null) // jika _subs tidak kosong
		{
			Delegate[] delegates = _subs.GetInvocationList(); // create delegate dalam array for subs and check subs
			if(delegates.Contains(del)) // Contains for check adakah subscriber in del
			{
				return true; // print true
			}
			return false; // print false
		}
		return false;
	}
	// create new method for sent notification
	public void SentNotification()
	{
		// if terdapat subscriber in _subs maka invoke("Hello Subscribers) di print
		_subs?.Invoke("Hello");
	}
}
public class Subscriber
{
	public void GetNotification()
	{
		Console.WriteLine("Hello");
	}
}
class Program
{
	static void Main()
	{
		// create new object for publisher and subscriber
		Publisher pub =	new();
		Subscriber sub = new();
		
		pub.AddSub(sub.GetNotification);
		pub.AddSub(sub.GetNotification);
		pub.AddSub(sub.GetNotification);
		pub.SentNotification(); 
	}
}

