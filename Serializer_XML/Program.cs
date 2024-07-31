// class must be public
using System.Dynamic;
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
		Room room = new Room();
		room.Name = "Meeting Room A";
		room.Id = 001;

		// for serializer XML
		XmlSerializer serializer = new(typeof(Room));
		
		// for create room.txt
		using (FileStream fs = new("./room.txt", FileMode.Create))
		{
			serializer.Serialize(fs, room);
		} 
	}
}