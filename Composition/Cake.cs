using Composition;
namespace CakeComposition;

// Create class cake
public class Cake
{
	
	// component or variable in cake
	public Tepung flour;
	public Oil oil;
	public Egg egg; 
	
	// Construction for class cake
	public Cake(Tepung tepung,Oil oil, Egg egg)
	{
		this.flour=tepung;
		this.oil=oil;
		this.egg=egg;
	}
}
