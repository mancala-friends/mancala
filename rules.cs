using System;

public class rules
{
    private gameState gamestate;

    public bool tryMove(int pit);

    public gameState getGamestate() { return gamestate; }

    
	public rules()
	{
        gamestate = new gameState();
	}
}
