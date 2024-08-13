using System.Security;

namespace SimpleGame;

public class GameController
{
	private List<IPlayer> players = new();
	public GameController(IPlayer a, IPlayer b)
	{
		players.Add(a);
		players.Add(b);
	}
	public int TotalPlayer()
	{
		return players.Count;
	}
	public bool AddPlayer(IPlayer player)
	{
		if(players.Contains(player))
		{
			return false;
		}
		players.Add(player);
		return true;
	}
	
}
