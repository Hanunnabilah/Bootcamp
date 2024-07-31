using System.Data.SqlTypes;
using System.Text;
using System.Text.Json;

public class Room
{
	public int Id{ get; set; }
	public string Name{get; set; }
	public RoomType roomType{ get; set; }
		
}
public enum RoomType
{
	Large,
	Medium, 
	Small
}
class Program
{
	static void Main()
	{
		Room room = new Room();
		room.Id = 1001;
		room.Name = "Meeting Room A";
		room.roomType = RoomType.Large;
		
		string result = JsonSerializer.Serialize(room);
		Console.WriteLine(result);
		
		using (FileStream fs = new("./room.json", FileMode.Create))
		{
			byte[] bytes = Encoding.UTF8.GetBytes(result);
			fs.Write(bytes, 0 , bytes.Length);
		}
		
		using(StreamWriter sw = new("./roomsw.json"))
		{
			sw.WriteLine(result);
		}
	}
}