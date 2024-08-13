using SimpleGame;
using Moq;

namespace SImpleGame.Test;

public class GameControllerTest
{
	private GameController _gameController;
	private Mock<IPlayer> playerA;
	private Mock<IPlayer> playerB;
	[SetUp]
	public void GameController()
	{
		playerA = new();
		playerA.Setup(p => p.GetName()).Returns("Jowo");
		playerB = new();
		playerB.Setup(p => p.GetName()).Returns("Wowo");
		_gameController = new(playerA.Object, playerB.Object);
	}

	[Test]
	public void TotalPlayer_ReturnTwo()
	{
		// Arrange
		int expected = 2;
		// Act
		int result = _gameController.TotalPlayer();
		// Assert
		Assert.That(result, Is.EqualTo(expected));
	}
}