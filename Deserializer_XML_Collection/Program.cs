using System.Xml.Serialization;

public class Room
{
	public int Id { get; set; }
	public string Name { get; set; }
	public Room(int id, string name)
	{
		Id = Id;
		Name = name;
	}
	// constructor parameterless
	public Room() {}
}
class Program
{
	static void Main()
	{
		List<Room> roomList = new();	
		// for convert using serializer
		XmlSerializer serializer = new(typeof(List<Room>));
		
		// for create file
		using (FileStream fs = new("./List_Room.txt", FileMode.Open))
		{
			roomList = (List<Room>)serializer.Deserialize(fs);
		}
		foreach(var i in roomList)
		{
			Console.WriteLine(i.Id);
			Console.WriteLine(i.Name);
		}
	}
}