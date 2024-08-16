using ConcreteBuilder;
using Dir;
using Product;
class Program
{
	static void Main(string[] args)
	{
		var builder = new WardrobeBuilder();
		var director = new Director();

		// Membangun Wardrobe Sederhana
		director.BuildSimpleWardrobe(builder);
		Wardrobe simpleWardrobe = builder.Build();
		Console.WriteLine(simpleWardrobe);

		// Membangun Wardrobe Mewah
		builder = new WardrobeBuilder(); // Reset builder untuk produk baru
		director.BuildLuxuryWardrobe(builder);
		Wardrobe luxuryWardrobe = builder.Build();
		Console.WriteLine(luxuryWardrobe);
	}
}