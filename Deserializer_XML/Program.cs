using System.IO;
using System.Xml.Serialization;

public class Room
{
	public int Id{ get; set; }
	public string Name { get; set; }
}
class Program
{
	static void Main()
	{
		XmlSerializer serializer = new(typeof(Room));
		Room room;
		using (FileStream fs = new("./room.txt", FileMode.Open))
		{
			room = (Room)serializer.Deserialize(fs);
		}
		Console.WriteLine(room.Id);
		Console.WriteLine(room.Name);
	}
}