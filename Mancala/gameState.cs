using System;

public class GameState
{

    public int[] playerOne;
    public int[] playerTwo;
    public int currentPlayer;

    public bool isEmpty(int[] player)
    {
        for(int i =0; i< 6; i++)
        {
            if(player[i] != 0)
            {
                return false;
            }
        }

        return true;
    }

    public bool isOver()
    {
      return isEmpty(playerOne) && isEmpty(playerTwo);
    }

    public GameState()
	{
        playerOne = new int[7] { 4, 4, 4, 4, 4, 4, 0 };
        playerTwo = new int[7] { 4, 4, 4, 4, 4, 4, 0 };

        Random random = new Random();
        currentPlayer = random.Next(1,3);
    }
}
