namespace Product;

public class Wardrobe
{
	public string DoorType { get; set; }
	public int NumberOfDoors { get; set; }
	public string Material { get; set; }
	public string Color { get; set; }
	public bool HasMirror { get; set; }

	public override string ToString()
	{
		string mirrorStatus = HasMirror ? "with mirror" : "without mirror";
		return $"Wardrobe with {NumberOfDoors} {DoorType} doors, made of {Material}, colored {Color}, {mirrorStatus}.";
	}
}
