using System.IO;
using System.Text;
using System.Text.Json;

public class Room
{
	public int Id { get; set; }
	public string Name { get; set; }
	public RoomType Type { get; set; }

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
			string result;
			using (StreamReader sr = new("./roomList.json"))
			{
				result = sr.ReadLine();
			}
			Room room = JsonSerializer.Deserialize<Room>(result);
			Console.WriteLine(room.Id);
			Console.WriteLine(room.Name);
		}
	} 
}

