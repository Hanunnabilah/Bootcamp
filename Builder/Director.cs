using InterfaceBuilder;

namespace Dir;

public class Director
{
	public void BuildSimpleWardrobe(IBuilder builder)
	{
		builder.SetDoorType("Sliding");
		builder.SetNumberOfDoors(2);
		builder.SetMaterial("Wood");
		builder.SetColor("White");
	}
	public void BuildLuxuryWardrobe(IBuilder builder)
	{
		builder.SetDoorType("Hinged");
		builder.SetNumberOfDoors(4);
		builder.SetMaterial("Plastic");
		builder.SetColor("Dark Brown");
		builder.AddMirror();
	}
}
