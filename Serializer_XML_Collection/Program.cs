using System.Xml.Serialization;

internal class Room
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
		Room room = new Room(1001, "Meeting Room A");
		Room room2 = new Room(1002, "Meeting Room B");
		Room room3 = new Room(1003, "BallRoom");
		Room room4 = new Room(1004, "Creative Studio");
		Room room5 = new Room(1005, "Pantry Room");
		
		List<Room> roomList = new();
		roomList.Add(room);
		roomList.Add(room2);
		roomList.Add(room3);
		roomList.Add(room4);
		roomList.Add(room5);
	
		XmlSerializer serializer = new(typeof(List<Room>));
		
		using (FileStream fs = new("./List_Room.txt", FileMode.Create))
		{
			serializer.Serialize(fs, roomList);
		}
	}
}