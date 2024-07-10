// constructor overloading (karna lebih dari 1 constructor)
class Home
{
	public int pintu;
	public int jendela;
	public string alamat;
	public string warna;
	
	//nama constructor sama dengan nama Class
	// constactor 1
	public Home( int door, int window, string address, string color)
	{
		this.pintu = door; 
		this.jendela = window;
		this.alamat	= address;
		this.warna = color;
		Console.WriteLine($"Home created : {pintu}, {jendela}, {alamat}, {warna}");
	}
	
	// contractor 2
	// tiap constructor harus beda parameter
	public Home( int door, int window)	{}
}

class Program
{
	static void Main()
	{
		Home home = new Home(2, 4, "solo", "putih");
		Console.WriteLine(home.pintu);
		Console.WriteLine(home.jendela);
		Console.WriteLine(home.warna);
		Console.WriteLine(home.alamat);
		
		Home home2 = new Home(2, 4);
	}
	
}