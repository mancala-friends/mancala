using System;

public class Rules
{
    public GameState gamestate;

    public bool tryMove(int pit)
    {
        if(pit < 0 || pit > 5)
        {
            return false;
        }

        if(gamestate.currentPlayer == 1)
        {
            if(gamestate.playerOne[pit] == 0)
            {
                return false;
            }
            else
            {
                move(pit);
                return true;
            }
        }
        else
        {
            if (gamestate.playerTwo[pit] == 0)
            {
                return false;
            }
            else
            {
                move(pit);
                return true;
            }
        }


    }

    private bool movePlayerOne(int pit)
    {
        //empty current pit
        int currentMovePebbles = gamestate.playerOne[pit];
        gamestate.playerOne[pit] = 0;

        int i = pit + 1;
        while (currentMovePebbles > 0)
        {
            //place pebbles on our side
            while (i < 7)
            {
                //check for end of turn
                if (currentMovePebbles == 0)
                {
                    //landed in store go again
                    if (i == 6)
                    {
                        return true;
                    }
                    else
                    {
                        //steal stuff
                        if (gamestate.playerOne[i] == 0 && gamestate.playerTwo[5-i] > 0)
                        {
                            gamestate.playerOne[6] += gamestate.playerTwo[5-i];
                            gamestate.playerOne[6] += gamestate.playerOne[i];
                            gamestate.playerOne[i] = 0;
                            gamestate.playerTwo[5-i] = 0;
                        }
                    }
                    return false;
                }
                else
                {
                    currentMovePebbles -= 1;
                    gamestate.playerOne[i] += 1;
                    i++;
                }
            }
            for (int j = 0; j < 6 && currentMovePebbles > 0; j++)
            {
                currentMovePebbles -= 1;
                gamestate.playerTwo[j] += 1;
            }
            i = 0;
        }
        return false;
    }

    private bool movePlayerTwo(int pit)
    {
        //empty current pit
        int currentMovePebbles = gamestate.playerTwo[pit];
        gamestate.playerTwo[pit] = 0;

        int i = pit + 1;
        while (currentMovePebbles > 0)
        {
            //place pebbles on our side
            while (i < 7)
            {
                //check for end of turn
                if (currentMovePebbles == 0)
                {
                    //landed in store go again
                    if (i == 6)
                    {
                        return true;
                    }
                    else
                    {
                        //steal stuff
                        if (gamestate.playerTwo[i] == 0 && gamestate.playerOne[5-i] > 0)
                        {
                            gamestate.playerTwo[6] += gamestate.playerOne[5-i];
                            gamestate.playerTwo[6] += gamestate.playerTwo[i];
                            gamestate.playerTwo[i] = 0;
                            gamestate.playerOne[5-i] = 0;
                        }
                    }
                    return false;
                }
                else
                {
                    currentMovePebbles -= 1;
                    gamestate.playerTwo[i] += 1;
                    i++;
                }
            }
            for (int j = 0; j < 6 && currentMovePebbles > 0; j++)
            {
                currentMovePebbles -= 1;
                gamestate.playerOne[j] += 1;
            }
            i = 0;
        }
        return false;
    }

    private void move(int pit)
    {
        bool goAgain = false;

        if(gamestate.currentPlayer == 1) {
            goAgain = movePlayerOne(pit);
        }
        else
        {
            goAgain = movePlayerTwo(pit);
        }

       if(!goAgain) gamestate.currentPlayer = (gamestate.currentPlayer == 1) ? 2 : 1;

    }

    public GameState getGamestate() { return gamestate; }


	public Rules()
	{
        gamestate = new GameState();
	}


}
