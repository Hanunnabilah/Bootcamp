using Product;

namespace InterfaceBuilder;

public interface IBuilder
{
	public void SetDoorType(string doorType);
	public void SetNumberOfDoors(int numberOfDoors);
	public void SetMaterial(string material);
	public void SetColor(string color);
	public void AddMirror();
	public Wardrobe Build();
}
