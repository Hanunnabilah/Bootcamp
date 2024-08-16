using InterfaceBuilder;
using Product;

namespace ConcreteBuilder;
public class WardrobeBuilder : IBuilder

{
	private Wardrobe _wardrobe = new Wardrobe();

	public void SetDoorType(string doorType)
	{
		_wardrobe.DoorType = doorType;
	}
	public void SetNumberOfDoors(int numberOfDoors)
	{
		_wardrobe.NumberOfDoors = numberOfDoors;
	}

	public void SetMaterial(string material)
	{
		_wardrobe.Material = material;
	}

	public void SetColor(string color)
	{
		_wardrobe.Color = color;
	}
	public void AddMirror()
	{
		_wardrobe.HasMirror = true;
	}
	public Wardrobe Build()
	{
		return _wardrobe;
	}
}