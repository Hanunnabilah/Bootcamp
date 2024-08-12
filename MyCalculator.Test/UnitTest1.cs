namespace MyCalculator.Test;

public class Tests
{
	private MyCalculator myCalculator;
	[SetUp]
	public void Setup()
	{
		MyCalculator = new MyCalculator();
	}

	[Test]
	public void Test1()
	{
		Assert.Pass();
	}
}