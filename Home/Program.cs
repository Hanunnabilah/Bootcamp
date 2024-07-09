class Program 

{
	static void Main()
	
	{
		Home salatiga = new Home();
		salatiga.wall = "White";
		salatiga.door = 2;
		salatiga.isMyhome = true;
		Console.WriteLine(salatiga.wall + " " + salatiga.door.ToString() + salatiga.isMyhome.ToString());
		Console.WriteLine(salatiga.door);
		Console.WriteLine(salatiga.isMyhome);
		
		salatiga.Myhome();
		
	}
}
