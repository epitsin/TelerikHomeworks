using System;
using System.IO;

public class ScoreHandler
{
    public static void Results(int score1, int score2)
    {
        //the same directory as the project
        string path = @"../../Results.txt";

        // Create a file to write to. 
        using (StreamWriter sw = new StreamWriter(path, false))
        {
            sw.WriteLine(score1.ToString());
            sw.WriteLine(score2.ToString());
        }
    }
}
