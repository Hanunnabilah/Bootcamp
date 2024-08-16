namespace WithoutBuilder;

public class Wardrobe
{
	public string DoorType { get; set; }
	public int NumberOfDoors { get; set; }
	public string Material { get; set; }
	public string Color { get; set; }
	public bool Mirror { get; set; }

	public Wardrobe(string doorType, int numberOfDoors, string material, string color, bool mirror)
	{
		DoorType = doorType;
		NumberOfDoors = numberOfDoors;
		Material = material;
		Color = color;
		Mirror = mirror;
	}
	public override string ToString()
	{
		return $"Wardrobe with {NumberOfDoors} {DoorType} doors, made of {Material}, colored {Color}, mirror {Mirror}";
	}
}
