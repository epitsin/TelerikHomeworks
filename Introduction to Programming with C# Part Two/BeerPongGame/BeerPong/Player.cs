using System;

public class Player
{
    private int currScore = 0;
    private byte gamesWon = 0;
    private byte drunked = 0;

    ConsoleColor playerColor = ConsoleColor.Gray;
    public Ball ball;

    public Player(ConsoleColor playerColor)
    {
        this.PlayerColor = playerColor;
        this.ball = new Ball(playerColor);
    }

    public int CurrentScore
    {
        get
        {
            return this.currScore;
        }
        set
        {
            this.currScore = value;
        }
    }

    public int GamesWon
    {
        get
        {
            return this.gamesWon;
        }
        set
        {
            this.gamesWon = (byte)value;
        }
    }

    public int Drunk
    {
        get
        {
            return this.drunked;
        }
    }

    //The player can pick a color on their own.
    public ConsoleColor PlayerColor
    {
        get
        {
            return this.playerColor;
        }
        set
        {
            this.playerColor = value;
        }
    }
}

