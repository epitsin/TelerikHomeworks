using System;
using System.Threading;

public class PingPong
{
    static void SetConsoleLength()
    {
        Console.SetWindowSize(120, 40);
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.CursorVisible = false;
        Console.Clear();
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        PrintTitle();
        Console.SetCursorPosition(Console.WindowWidth / 2 + 20, 0);
        Console.WriteLine("To move the player use {0} and {1}", (char)24, (char)25);
        Console.SetCursorPosition(Console.WindowWidth / 2 + 20, 1);
        Console.WriteLine("To adjust the ball's speed use {0} and {1}", (char)26, (char)27);
        Console.SetCursorPosition(Console.WindowWidth / 2 + 20, 2);
        Console.WriteLine("To throw the ball use space");
    }

    static void PrintTitle()
    {
        Console.SetCursorPosition(Console.WindowWidth / 2 - 37, 0);
        Console.Write(@"||==)  ||==  ||== ||==)    ||==)  /=\  |\ ||   /==\_\");
        Console.SetCursorPosition(Console.WindowWidth / 2 - 37, 1);
        Console.Write(@"||-<   ||=   ||=  ||-<     ||-<  ( O ) ||\||  ( ( ___");
        Console.SetCursorPosition(Console.WindowWidth / 2 - 37, 2);
        Console.Write(@"||==)  ||==  ||== ||  \    ||     \_/  || \|   \_\/_/");
    }

    static void PrintCurrentScore(int score1, int score2, int turn)
    {
        Console.SetCursorPosition(0, 0);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Red player score: {0}", score1);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Blue player score: {0}", score2);
        Console.WriteLine("Turn {0} of 10.", turn);
    }

    static void PrintCupsBases()
    {
        #region 1-st cup
        PrintAtPosition(Console.BufferWidth - 39, Console.BufferHeight - 4, ',');
        PrintAtPosition(Console.BufferWidth - 38, Console.BufferHeight - 4, ',');
        PrintAtPosition(Console.BufferWidth - 37, Console.BufferHeight - 4, ',');
        PrintAtPosition(Console.BufferWidth - 36, Console.BufferHeight - 4, ',');
        PrintAtPosition(Console.BufferWidth - 35, Console.BufferHeight - 4, ',');
        PrintAtPosition(Console.BufferWidth - 34, Console.BufferHeight - 4, ',');
        PrintAtPosition(Console.BufferWidth - 39, Console.BufferHeight - 3, '=');
        PrintAtPosition(Console.BufferWidth - 38, Console.BufferHeight - 3, '=');
        PrintAtPosition(Console.BufferWidth - 37, Console.BufferHeight - 3, '=');
        PrintAtPosition(Console.BufferWidth - 36, Console.BufferHeight - 3, '=');
        PrintAtPosition(Console.BufferWidth - 35, Console.BufferHeight - 3, '=');
        PrintAtPosition(Console.BufferWidth - 34, Console.BufferHeight - 3, '=');
        //left side
        PrintAtPosition(Console.BufferWidth - 40, Console.BufferHeight - 4, '|');
        PrintAtPosition(Console.BufferWidth - 40, Console.BufferHeight - 3, '|');
        PrintAtPosition(Console.BufferWidth - 40, Console.BufferHeight - 2, '|');

        PrintAtPosition(Console.BufferWidth - 33, Console.BufferHeight - 4, '|');
        PrintAtPosition(Console.BufferWidth - 33, Console.BufferHeight - 3, '|');
        PrintAtPosition(Console.BufferWidth - 33, Console.BufferHeight - 2, '|');
        PrintAtPosition(Console.BufferWidth - 37, Console.BufferHeight - 2, '5');
        PrintAtPosition(Console.BufferWidth - 36, Console.BufferHeight - 2, 'p');
        #endregion
        #region 2-nd cup
        //surface
        PrintAtPosition(Console.BufferWidth - 31, Console.BufferHeight - 8, ',');
        PrintAtPosition(Console.BufferWidth - 30, Console.BufferHeight - 8, ',');
        PrintAtPosition(Console.BufferWidth - 29, Console.BufferHeight - 8, ',');
        PrintAtPosition(Console.BufferWidth - 28, Console.BufferHeight - 8, ',');
        PrintAtPosition(Console.BufferWidth - 27, Console.BufferHeight - 8, ',');
        PrintAtPosition(Console.BufferWidth - 26, Console.BufferHeight - 8, ',');
        PrintAtPosition(Console.BufferWidth - 31, Console.BufferHeight - 7, '=');
        PrintAtPosition(Console.BufferWidth - 30, Console.BufferHeight - 7, '=');
        PrintAtPosition(Console.BufferWidth - 29, Console.BufferHeight - 7, '=');
        PrintAtPosition(Console.BufferWidth - 28, Console.BufferHeight - 7, '=');
        PrintAtPosition(Console.BufferWidth - 27, Console.BufferHeight - 7, '=');
        PrintAtPosition(Console.BufferWidth - 26, Console.BufferHeight - 7, '=');
        //left side
        PrintAtPosition(Console.BufferWidth - 32, Console.BufferHeight - 8, '|');
        PrintAtPosition(Console.BufferWidth - 32, Console.BufferHeight - 7, '|');
        PrintAtPosition(Console.BufferWidth - 32, Console.BufferHeight - 6, '|');
        PrintAtPosition(Console.BufferWidth - 32, Console.BufferHeight - 5, '|');
        PrintAtPosition(Console.BufferWidth - 32, Console.BufferHeight - 4, '|');
        PrintAtPosition(Console.BufferWidth - 32, Console.BufferHeight - 3, '|');
        PrintAtPosition(Console.BufferWidth - 32, Console.BufferHeight - 2, '|');

        PrintAtPosition(Console.BufferWidth - 25, Console.BufferHeight - 8, '|');
        PrintAtPosition(Console.BufferWidth - 25, Console.BufferHeight - 7, '|');
        PrintAtPosition(Console.BufferWidth - 25, Console.BufferHeight - 6, '|');
        PrintAtPosition(Console.BufferWidth - 25, Console.BufferHeight - 5, '|');
        PrintAtPosition(Console.BufferWidth - 25, Console.BufferHeight - 4, '|');
        PrintAtPosition(Console.BufferWidth - 25, Console.BufferHeight - 3, '|');
        PrintAtPosition(Console.BufferWidth - 25, Console.BufferHeight - 2, '|');
        PrintAtPosition(Console.BufferWidth - 30, Console.BufferHeight - 2, '1');
        PrintAtPosition(Console.BufferWidth - 29, Console.BufferHeight - 2, '0');
        PrintAtPosition(Console.BufferWidth - 28, Console.BufferHeight - 2, 'p');
        #endregion
        #region 3-th cup
        PrintAtPosition(Console.BufferWidth - 23, Console.BufferHeight - 16, ',');
        PrintAtPosition(Console.BufferWidth - 22, Console.BufferHeight - 16, ',');
        PrintAtPosition(Console.BufferWidth - 21, Console.BufferHeight - 16, ',');
        PrintAtPosition(Console.BufferWidth - 20, Console.BufferHeight - 16, ',');
        PrintAtPosition(Console.BufferWidth - 19, Console.BufferHeight - 16, ',');
        PrintAtPosition(Console.BufferWidth - 18, Console.BufferHeight - 16, ',');
        PrintAtPosition(Console.BufferWidth - 23, Console.BufferHeight - 15, '=');
        PrintAtPosition(Console.BufferWidth - 22, Console.BufferHeight - 15, '=');
        PrintAtPosition(Console.BufferWidth - 21, Console.BufferHeight - 15, '=');
        PrintAtPosition(Console.BufferWidth - 20, Console.BufferHeight - 15, '=');
        PrintAtPosition(Console.BufferWidth - 19, Console.BufferHeight - 15, '=');
        PrintAtPosition(Console.BufferWidth - 18, Console.BufferHeight - 15, '=');
        //left side
        PrintAtPosition(Console.BufferWidth - 24, Console.BufferHeight - 16, '|');
        PrintAtPosition(Console.BufferWidth - 24, Console.BufferHeight - 15, '|');
        PrintAtPosition(Console.BufferWidth - 24, Console.BufferHeight - 14, '|');
        PrintAtPosition(Console.BufferWidth - 24, Console.BufferHeight - 13, '|');
        PrintAtPosition(Console.BufferWidth - 24, Console.BufferHeight - 12, '|');
        PrintAtPosition(Console.BufferWidth - 24, Console.BufferHeight - 11, '|');
        PrintAtPosition(Console.BufferWidth - 24, Console.BufferHeight - 10, '|');
        PrintAtPosition(Console.BufferWidth - 24, Console.BufferHeight - 9, '|');
        PrintAtPosition(Console.BufferWidth - 24, Console.BufferHeight - 8, '|');
        PrintAtPosition(Console.BufferWidth - 24, Console.BufferHeight - 7, '|');
        PrintAtPosition(Console.BufferWidth - 24, Console.BufferHeight - 6, '|');
        PrintAtPosition(Console.BufferWidth - 24, Console.BufferHeight - 5, '|');
        PrintAtPosition(Console.BufferWidth - 24, Console.BufferHeight - 4, '|');
        PrintAtPosition(Console.BufferWidth - 24, Console.BufferHeight - 3, '|');
        PrintAtPosition(Console.BufferWidth - 24, Console.BufferHeight - 2, '|');

        PrintAtPosition(Console.BufferWidth - 17, Console.BufferHeight - 16, '|');
        PrintAtPosition(Console.BufferWidth - 17, Console.BufferHeight - 15, '|');
        PrintAtPosition(Console.BufferWidth - 17, Console.BufferHeight - 14, '|');
        PrintAtPosition(Console.BufferWidth - 17, Console.BufferHeight - 13, '|');
        PrintAtPosition(Console.BufferWidth - 17, Console.BufferHeight - 12, '|');
        PrintAtPosition(Console.BufferWidth - 17, Console.BufferHeight - 11, '|');
        PrintAtPosition(Console.BufferWidth - 17, Console.BufferHeight - 10, '|');
        PrintAtPosition(Console.BufferWidth - 17, Console.BufferHeight - 9, '|');
        PrintAtPosition(Console.BufferWidth - 17, Console.BufferHeight - 8, '|');
        PrintAtPosition(Console.BufferWidth - 17, Console.BufferHeight - 7, '|');
        PrintAtPosition(Console.BufferWidth - 17, Console.BufferHeight - 6, '|');
        PrintAtPosition(Console.BufferWidth - 17, Console.BufferHeight - 5, '|');
        PrintAtPosition(Console.BufferWidth - 17, Console.BufferHeight - 4, '|');
        PrintAtPosition(Console.BufferWidth - 17, Console.BufferHeight - 3, '|');
        PrintAtPosition(Console.BufferWidth - 17, Console.BufferHeight - 2, '|');
        PrintAtPosition(Console.BufferWidth - 22, Console.BufferHeight - 2, '1');
        PrintAtPosition(Console.BufferWidth - 21, Console.BufferHeight - 2, '5');
        PrintAtPosition(Console.BufferWidth - 20, Console.BufferHeight - 2, 'p');
        #endregion
        #region 4-th cup
        //surface
        PrintAtPosition(Console.BufferWidth - 15, Console.BufferHeight - 8, ',');
        PrintAtPosition(Console.BufferWidth - 14, Console.BufferHeight - 8, ',');
        PrintAtPosition(Console.BufferWidth - 13, Console.BufferHeight - 8, ',');
        PrintAtPosition(Console.BufferWidth - 12, Console.BufferHeight - 8, ',');
        PrintAtPosition(Console.BufferWidth - 11, Console.BufferHeight - 8, ',');
        PrintAtPosition(Console.BufferWidth - 10, Console.BufferHeight - 8, ',');
        PrintAtPosition(Console.BufferWidth - 15, Console.BufferHeight - 7, '=');
        PrintAtPosition(Console.BufferWidth - 14, Console.BufferHeight - 7, '=');
        PrintAtPosition(Console.BufferWidth - 13, Console.BufferHeight - 7, '=');
        PrintAtPosition(Console.BufferWidth - 12, Console.BufferHeight - 7, '=');
        PrintAtPosition(Console.BufferWidth - 11, Console.BufferHeight - 7, '=');
        PrintAtPosition(Console.BufferWidth - 10, Console.BufferHeight - 7, '=');
        //left side
        PrintAtPosition(Console.BufferWidth - 16, Console.BufferHeight - 8, '|');
        PrintAtPosition(Console.BufferWidth - 16, Console.BufferHeight - 7, '|');
        PrintAtPosition(Console.BufferWidth - 16, Console.BufferHeight - 6, '|');
        PrintAtPosition(Console.BufferWidth - 16, Console.BufferHeight - 5, '|');
        PrintAtPosition(Console.BufferWidth - 16, Console.BufferHeight - 4, '|');
        PrintAtPosition(Console.BufferWidth - 16, Console.BufferHeight - 3, '|');
        PrintAtPosition(Console.BufferWidth - 16, Console.BufferHeight - 2, '|');

        PrintAtPosition(Console.BufferWidth - 9, Console.BufferHeight - 8, '|');
        PrintAtPosition(Console.BufferWidth - 9, Console.BufferHeight - 7, '|');
        PrintAtPosition(Console.BufferWidth - 9, Console.BufferHeight - 6, '|');
        PrintAtPosition(Console.BufferWidth - 9, Console.BufferHeight - 5, '|');
        PrintAtPosition(Console.BufferWidth - 9, Console.BufferHeight - 4, '|');
        PrintAtPosition(Console.BufferWidth - 9, Console.BufferHeight - 3, '|');
        PrintAtPosition(Console.BufferWidth - 9, Console.BufferHeight - 2, '|');
        PrintAtPosition(Console.BufferWidth - 14, Console.BufferHeight - 2, '2');
        PrintAtPosition(Console.BufferWidth - 13, Console.BufferHeight - 2, '0');
        PrintAtPosition(Console.BufferWidth - 12, Console.BufferHeight - 2, 'p');
        #endregion
        #region 5-th cup
        //surface
        PrintAtPosition(Console.BufferWidth - 7, Console.BufferHeight - 4, ',');
        PrintAtPosition(Console.BufferWidth - 6, Console.BufferHeight - 4, ',');
        PrintAtPosition(Console.BufferWidth - 5, Console.BufferHeight - 4, ',');
        PrintAtPosition(Console.BufferWidth - 4, Console.BufferHeight - 4, ',');
        PrintAtPosition(Console.BufferWidth - 3, Console.BufferHeight - 4, ',');
        PrintAtPosition(Console.BufferWidth - 2, Console.BufferHeight - 4, ',');
        PrintAtPosition(Console.BufferWidth - 7, Console.BufferHeight - 3, '=');
        PrintAtPosition(Console.BufferWidth - 6, Console.BufferHeight - 3, '=');
        PrintAtPosition(Console.BufferWidth - 5, Console.BufferHeight - 3, '=');
        PrintAtPosition(Console.BufferWidth - 4, Console.BufferHeight - 3, '=');
        PrintAtPosition(Console.BufferWidth - 3, Console.BufferHeight - 3, '=');
        PrintAtPosition(Console.BufferWidth - 2, Console.BufferHeight - 3, '=');
        //left side
        PrintAtPosition(Console.BufferWidth - 8, Console.BufferHeight - 4, '|');
        PrintAtPosition(Console.BufferWidth - 8, Console.BufferHeight - 3, '|');
        PrintAtPosition(Console.BufferWidth - 8, Console.BufferHeight - 2, '|');
        PrintAtPosition(Console.BufferWidth - 1, Console.BufferHeight - 4, '|');
        PrintAtPosition(Console.BufferWidth - 1, Console.BufferHeight - 3, '|');
        PrintAtPosition(Console.BufferWidth - 1, Console.BufferHeight - 2, '|');

        PrintAtPosition(Console.BufferWidth - 6, Console.BufferHeight - 2, '2');
        PrintAtPosition(Console.BufferWidth - 5, Console.BufferHeight - 2, '5');
        PrintAtPosition(Console.BufferWidth - 4, Console.BufferHeight - 2, 'p');
        #endregion
        #region Extra cup points
        PrintAtPosition(Console.BufferWidth - 5, Console.BufferHeight - 27, '6');
        PrintAtPosition(Console.BufferWidth - 4, Console.BufferHeight - 27, '0');
        PrintAtPosition(Console.BufferWidth - 3, Console.BufferHeight - 27, 'p');
        #endregion
    }
    static void PrintCups(int leftCornerWidth, int leftCornerHeight)
    {
        //   \~~~~~~/
        //    \    / 
        //     \__/  
        char[,] cup = new char[3, 8];
        Console.SetCursorPosition(leftCornerWidth, leftCornerHeight);
        cup[0, 0] = '\\';
        cup[0, 1] = '~';
        cup[0, 2] = '~';
        cup[0, 3] = '~';
        cup[0, 4] = '~';
        cup[0, 5] = '~';
        cup[0, 6] = '~';
        cup[0, 7] = '/';

        cup[1, 0] = ' ';
        cup[1, 1] = '\\';
        cup[1, 2] = ' ';
        cup[1, 3] = ' ';
        cup[1, 4] = ' ';
        cup[1, 5] = ' ';
        cup[1, 6] = '/';
        cup[1, 7] = ' ';

        cup[2, 0] = ' ';
        cup[2, 1] = ' ';
        cup[2, 2] = '\\';
        cup[2, 3] = '_';
        cup[2, 4] = '_';
        cup[2, 5] = '/';
        cup[2, 6] = ' ';
        cup[2, 7] = ' ';

        for (int i = 0; i < 3; i++)
        {
            Console.SetCursorPosition(leftCornerWidth, leftCornerHeight + i);
            for (int j = 0; j < cup.Length / 3; j++)
            {
                Console.Write(cup[i, j]);
                Ball.FillField(leftCornerWidth + j, leftCornerHeight + i); 
            }
        }
    }

    static void PrintAtPosition(int x, int y, char symbol)
    {
        Console.SetCursorPosition(x, y);
        Ball.FillField(x, y); 
        Console.Write(symbol);
    }

    static void DisplayRedPlayer()
    {
        Console.SetCursorPosition(0, 0);
        Console.ForegroundColor = ConsoleColor.Red;
    }
    static void DisplayBluePlayer()
    {
        Console.SetCursorPosition(0, 1);
        Console.ForegroundColor = ConsoleColor.Blue;
    }

    static void Main()
    {
        Screen screen = new Screen();
        screen.HomeScreen();

        //Initializing the players with their balls:
        Player Blue = new Player(ConsoleColor.Blue);
        Player Red = new Player(ConsoleColor.Red);

        for (int turn = 1; turn <= 10; turn++)
        {

            SetConsoleLength();
            PrintCurrentScore(Red.CurrentScore, Blue.CurrentScore, turn);
            PrintCupsBases();

            PrintCups(Console.BufferWidth - 40, Console.BufferHeight - 7);
            PrintCups(Console.BufferWidth - 32, Console.BufferHeight - 11);
            PrintCups(Console.BufferWidth - 24, Console.BufferHeight - 19);
            PrintCups(Console.BufferWidth - 16, Console.BufferHeight - 11);
            PrintCups(Console.BufferWidth - 8, Console.BufferHeight - 7);
            PrintCups(Console.BufferWidth - 8, Console.BufferHeight - 30);

            DisplayRedPlayer();
            DisplayBluePlayer();
            Console.SetCursorPosition(20, 15);

            Red.ball = new Ball(Red.PlayerColor);
            Red.ball.SetupBall();
            Red.ball.Throw(Blue.CurrentScore);
            Red.CurrentScore += Red.ball.ScoreGained();
            PrintCurrentScore(Red.CurrentScore, Blue.CurrentScore, turn);

            Blue.ball = new Ball(Blue.PlayerColor);
            Blue.ball.SetupBall();
            Blue.ball.Throw(Red.CurrentScore);
            Blue.CurrentScore += Blue.ball.ScoreGained();
            PrintCurrentScore(Red.CurrentScore, Blue.CurrentScore, turn);

            Thread.Sleep(1000);
            Console.Clear();
            SetConsoleLength();
        }

        ScoreHandler.Results(Red.CurrentScore, Blue.CurrentScore);
        Console.SetCursorPosition(0, Console.WindowHeight - 1);
        screen.FinalScreen();
    }
}