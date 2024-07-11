namespace Time;
public class Clock
{
	public string brand;
	public int quantity;
	private string _design;
	
	private void Exclusive(string design)
	{
		_design = design;
		Console.WriteLine("This models is exclusive = " + _design);
	} 
}