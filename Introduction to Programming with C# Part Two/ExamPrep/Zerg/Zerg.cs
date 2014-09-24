using System;

namespace Zerg
{
    class Zerg
    {
        static void Main()
        {
            string input = Console.ReadLine();
            double num = 0;
            int pow = 0;
            for (int i = input.Length - 1; i >= 0; i-=4)
            {
                string sub = input.Substring(i - 3, 4);
                switch(sub)
                {
                    case "Rawr" : num+=Math.Pow(15,pow)*0;   break;
                    case "Rrrr" : num+=Math.Pow(15,pow)*1;   break;
                    case "Hsst" : num+=Math.Pow(15,pow)*2;   break;
                    case "Ssst" : num+=Math.Pow(15,pow)*3;   break;
                    case "Grrr" : num+=Math.Pow(15,pow)*4;   break;
                    case "Rarr" : num+=Math.Pow(15,pow)*5;   break;
                    case "Mrrr" : num+=Math.Pow(15,pow)*6;   break;
                    case "Psst" : num+=Math.Pow(15,pow)*7;   break;
                    case "Uaah" : num+=Math.Pow(15,pow)*8;   break;
                    case "Uaha" : num+=Math.Pow(15,pow)*9;   break;
                    case "Zzzz" : num+=Math.Pow(15,pow)*10;   break;
                    case "Bauu" : num+=Math.Pow(15,pow)*11;   break;
                    case "Djav" : num+=Math.Pow(15,pow)*12;   break;
                    case "Myau" : num+=Math.Pow(15,pow)*13;   break;
                    case "Gruh": num += Math.Pow(15, pow) * 14; break;

                }
                pow++;
            }
            Console.WriteLine(num);
        }
    }
}
