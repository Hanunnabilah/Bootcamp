using WithoutBuilder;
class Program
{
	static void Main()
	{
		// Membangun Wardrobe Sederhana
		Wardrobe simpleWardrobe = new Wardrobe("Sliding", 2, "Wood", "White", false);
		Console.WriteLine(simpleWardrobe);

		// Membangun Wardrobe Mewah
		Wardrobe luxuryWardrobe = new Wardrobe("Hinged", 4, "Plastic", "Dark Brown", true);
		Console.WriteLine(luxuryWardrobe);
	}
}
