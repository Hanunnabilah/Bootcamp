﻿using System.Runtime.Serialization;

[DataContract]
public class Room
{
	[DataMember]
	private string _name;
	[DataMember]
	private int _id;
	[DataMember]
	public RoomType roomType { get; set; }
	public Room(string name, int id, RoomType roomType)
	{
		_name = name;
		_id = id;
		roomType = roomType;
	}
	public string GetName() => _name;
	public int GetId() => _id;
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
			Room room = new Room("Meeting Room A", 10001 , RoomType.Large);

			DataContractSerializer dataContract = new(typeof(Room));
			//Write
			using (FileStream fs = new("./roomList.xml", FileMode.Create))
			{
				dataContract.WriteObject(fs, room);
			}

			//Read
			Room room2;
			using (FileStream fs = new("./roomList.xml", FileMode.Open))
			{
				room2 = (Room)dataContract.ReadObject(fs);
			}
			Console.WriteLine(room.GetName());
			Console.WriteLine(room.GetId());

		}
	}
}