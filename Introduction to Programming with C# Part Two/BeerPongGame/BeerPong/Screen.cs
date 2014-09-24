using System;
using System.Threading;
using System.IO;

class Screen
{
    static int startRow = 3;
    static int startCol = 25 + letterWidth / 2;
    int currentRow = startRow;
    int currentCol = startCol;
    const int letterHeight = 13;
    const int letterWidth = 10;
    string wordSymbol = "*****";

    public void HomeScreen()
    {
        FormatConsole();
        DrawGameName(false);

        Thread.Sleep(1000);
        Console.SetCursorPosition(45, 19);
        Console.WriteLine("Press Enter to continue...");
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.ReadLine();
    }

    public void FinalScreen()
    {
        FormatConsole();
        currentRow = startRow;
        currentCol = startCol;

        int redPlayerScore;
        int bluePlayerScore;
        string path = @"..\..\Results.txt";

        using (StreamReader reader = new StreamReader(path))
        {
            redPlayerScore = int.Parse(reader.ReadLine());
            bluePlayerScore = int.Parse(reader.ReadLine());
        }

        int row = 18;
        PrintFinalResults(row, 40, "Red player final score is: " + redPlayerScore);
        row++;
        PrintFinalResults(row, 40, "Blue player final score is: " + bluePlayerScore);
        row++;

        if (redPlayerScore > bluePlayerScore)
            PrintFinalResults(row, 40, "Red player is the winner! Congratulations!");
        else if (redPlayerScore < bluePlayerScore)
            PrintFinalResults(row, 40, "Blue player is the winner! Congratulations!");
        else
            PrintFinalResults(row, 40, "The game ends in a draw!");

        DrawGameName(true);

        row += letterHeight + 4;
        PrintFinalResults(row, 40, "Thank you for playing.");
        row++;
        PrintFinalResults(row, 40, "Press Enter to close the window...");
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.SetCursorPosition(0, 0);
        Console.ReadLine();
    }

    void FormatConsole()
    {
        Console.SetWindowSize(120, 40);
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.CursorVisible = false;
        Console.Clear();
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }

    void PrintFinalResults(int row, int col, string text)
    {
        Console.SetCursorPosition(col, row);
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(text);
    }

    void PrintAtPosition(int row, int col)
    {
        Console.SetCursorPosition(col, row);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(wordSymbol);
        Console.BackgroundColor = ConsoleColor.Black;
    }

    void DrawGameName(bool slow)
    {
        DrawLetterB();
        if (slow)
            Thread.Sleep(500);
        DrawLetterE();
        if (slow)
            Thread.Sleep(500);
        DrawLetterE();
        if (slow)
            Thread.Sleep(500);
        DrawLetterR();
        if (slow)
            Thread.Sleep(500);
        DrawLetterP();
        if (slow)
            Thread.Sleep(500);
        DrawLetterO();
        if (slow)
            Thread.Sleep(500);
        DrawLetterN();
        if (slow)
            Thread.Sleep(500);
        DrawLetterG();
        if (slow)
            Thread.Sleep(500);
    }

    void DrawLetterB()
    {
        for (int row = 0; row <= letterHeight; row++)
        {
            PrintAtPosition(currentRow + row, currentCol);
            if (row < letterHeight / 2)
            {
                PrintAtPosition(currentRow + row, currentCol + letterWidth - 1);
            }
            else
            {
                PrintAtPosition(currentRow + row, currentCol + letterWidth);
            }
        }

        for (int col = 0; col < letterWidth; col++)
        {
            PrintAtPosition(currentRow + letterHeight, currentCol + col);
            PrintAtPosition(currentRow + letterHeight / 2, currentCol + col);

            if (col < letterWidth - 1)
            {
                PrintAtPosition(currentRow, currentCol + col);
            }
        }

        currentCol += letterWidth + wordSymbol.Length + 1;
    }

    void DrawLetterE()
    {
        for (int row = 0; row <= letterHeight; row++)
        {
            PrintAtPosition(currentRow + row, currentCol);
        }

        for (int col = 0; col < letterWidth - 1; col++)
        {
            PrintAtPosition(currentRow + letterHeight, currentCol + col);
            PrintAtPosition(currentRow, currentCol + col);

            if (col < letterHeight / 2)
            {
                PrintAtPosition(currentRow + letterHeight / 2, currentCol + col);
            }
        }
        currentCol += letterWidth + wordSymbol.Length - 1;
    }

    void DrawLetterR()
    {
        for (int row = 0; row <= letterHeight; row++)
        {
            PrintAtPosition(currentRow + row, currentCol);
            if (row <= letterHeight / 2)
            {
                PrintAtPosition(currentRow + row, currentCol + letterWidth - 1);
            }
        }

        for (int row = 0, col = 0; col < letterWidth; row++, col++)
        {
            PrintAtPosition(currentRow, currentCol + row);
            PrintAtPosition(currentRow + letterHeight / 2, currentCol + col);
            if (letterHeight / 2 + row <= letterHeight)
            {
                PrintAtPosition(currentRow + letterHeight / 2 + row, currentCol + col + 2);
            }
        }
        currentRow = startRow + letterHeight + letterHeight / 2;
        currentCol = startCol - letterWidth / 3;
    }

    void DrawLetterP()
    {
        for (int row = 0; row <= letterHeight; row++)
        {
            PrintAtPosition(currentRow + row, currentCol);
            if (row <= letterHeight / 2)
            {
                PrintAtPosition(currentRow + row, currentCol + letterWidth - 1);
            }
        }

        for (int row = 0, col = 0; col < letterWidth; row++, col++)
        {
            PrintAtPosition(currentRow, currentCol + row);
            PrintAtPosition(currentRow + letterHeight / 2, currentCol + col);
        }
        currentCol += letterWidth + wordSymbol.Length;
    }

    void DrawLetterO()
    {
        for (int row = 0; row <= letterHeight; row++)
        {
            PrintAtPosition(currentRow + row, currentCol);
            PrintAtPosition(currentRow + row, currentCol + letterWidth - 1);
        }

        for (int col = 0; col < letterWidth - 1; col++)
        {
            PrintAtPosition(currentRow, currentCol + col);
            PrintAtPosition(currentRow + letterHeight, currentCol + col);
        }
        currentCol += letterWidth + wordSymbol.Length;
    }

    void DrawLetterN()
    {
        for (int row = 0, col = 0; row <= letterHeight; row++, col++)
        {
            PrintAtPosition(currentRow + row, currentCol);
            PrintAtPosition(currentRow + row, currentCol + letterHeight);
            PrintAtPosition(currentRow + row, currentCol + col);
        }
        currentCol += letterHeight + wordSymbol.Length + 1;
    }

    void DrawLetterG()
    {
        for (int row = 0; row <= letterHeight; row++)
        {
            PrintAtPosition(currentRow + row, currentCol);
            if (row < letterHeight / 3 || row > letterHeight / 2 - 1)
            {
                PrintAtPosition(currentRow + row, currentCol + letterWidth);
            }

            if (row == letterHeight / 2)
            {
                PrintAtPosition(currentRow + letterHeight / 2, currentCol + letterHeight / 2 + 1);
                PrintAtPosition(currentRow + letterHeight / 2 + 1, currentCol + letterHeight / 2 + 1);
            }
        }

        for (int col = 0; col < letterWidth; col++)
        {
            PrintAtPosition(currentRow, currentCol + col);
            PrintAtPosition(currentRow + letterHeight, currentCol + col);
        }
    }
}
