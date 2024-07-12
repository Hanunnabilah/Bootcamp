abstract class Shape
{
	public abstract int getArea();
}
class Rectangle : Shape
{
	private int width;
	private int height;
	
	public Rectangle(int width, int height)
	{
		this.width = width;
		this.height = height;
	}
	public override int getArea()
	{
		return width*height;
	}
}
class Program
{
	static void Main()
	{
		Rectangle myRectangle = new Rectangle(10, 10);
		// myRectangle.getArea();
		// Console.WriteLine(myRectangle.width);
		// Console.WriteLine(myRectangle.height);
		Console.WriteLine(myRectangle.getArea());
	}
}