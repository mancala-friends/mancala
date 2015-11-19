using System;

public class Rules
{
    public GameState gamestate;

    public Rules(GameState game)
    {
        gamestate = game;
    }

    public Rules(int playerTurn)
    {
        gamestate = new GameState();
        gamestate.currentPlayer = playerTurn;
    }

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

    private void clearpits() {
      for(int i = 0; i < 6; i++) {
        gamestate.playerOne[6] += gamestate.playerOne[i];
        gamestate.playerOne[i] = 0;
        gamestate.playerTwo[6] += gamestate.playerTwo[i];
        gamestate.playerTwo[i] = 0;
      }
    }

    private bool movePlayer(int pit, int[] playerOne, int[] playerTwo)
    {
        //empty current pit
        int currentMovePebbles = playerTwo[pit];
        playerTwo[pit] = 0;

        int i = pit + 1;
        while (currentMovePebbles > 0)
        {
            //place pebbles on our side
            while (i < 7)
            {
                currentMovePebbles -= 1;
                playerTwo[i] += 1;
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
                        if (playerTwo[i] == 1 && playerOne[5 - i] > 0)
                        {
                            playerTwo[6] += playerOne[5 - i];
                            playerTwo[6] += playerTwo[i];
                            playerTwo[i] = 0;
                            playerOne[5 - i] = 0;
                        }
                    }
                    return false;
                }
                i++;
            }
            for (int j = 0; j < 6 && currentMovePebbles > 0; j++)
            {
                currentMovePebbles -= 1;
                playerOne[j] += 1;
            }
            i = 0;
        }
        return false;
    }

    private void move(int pit)
    {
        bool goAgain = false;

        if(gamestate.currentPlayer == 2)
        {
            goAgain = movePlayer(pit, gamestate.playerOne, gamestate.playerTwo);
        }
        else
        {
            goAgain = movePlayer(pit, gamestate.playerTwo, gamestate.playerOne);
        }

        if(gamestate.isEmpty(gamestate.playerOne) || gamestate.isEmpty(gamestate.playerTwo)) clearpits();

        if(!goAgain) gamestate.currentPlayer = (gamestate.currentPlayer == 1) ? 2 : 1;

    }

    public GameState getGamestate() { return gamestate; }


	public Rules()
	{
        gamestate = new GameState();
	}


}
