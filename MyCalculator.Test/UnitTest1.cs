namespace MyCalculator.Test;

public class MyCalculatorTest
{
	private MyCalculator _calculator;
	[SetUp]
	public void Setup()
	{
		_calculator = new MyCalculator();
	}

	[Test]
	public void Add_ReturnCorrectResult()
	{
		// Arrange
		int x = 3;
		int y = 3;
		int expected = 6;
		// Act
		int result = _calculator.Add(x, y);
		// Assert
		Assert.That(result, Is.EqualTo(expected));
	}
	[TestCase(3,2,5)]
	[TestCase(-3,-4,-7)]
	[TestCase(3,-1,2)]
	[TestCase(2,4,6)]
	public void Add_ReturnCorrectResult(int x, int y, int expected)
	{
		// Arrange
		// Act
		int result = _calculator.Add(x,y);
		// Assert
		Assert.That(result, Is.EqualTo(expected)); 
	}
}