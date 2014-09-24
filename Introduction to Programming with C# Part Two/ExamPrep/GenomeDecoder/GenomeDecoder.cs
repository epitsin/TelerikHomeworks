using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenomeDecoder
{
    class GenomeDecoder
    {
        static void Main()
        {
            string[] inputNums = Console.ReadLine().Split(' ');

            int maxSymbols = int.Parse(inputNums[0]);
            int sequence = int.Parse(inputNums[1]);

            string decoded = Console.ReadLine();

            StringBuilder encoded = new StringBuilder();

            for (int i = 0; i < decoded.Length; i++)
            {
                int number = 1;
                StringBuilder num = new StringBuilder();
                if (int.TryParse(decoded[i].ToString(), out number))
                {
                    while (int.TryParse(decoded[i].ToString(), out number))
                    {
                        num.Append(decoded[i]);
                        i++;
                    }

                    number = int.Parse(num.ToString());
                }
                else
                {
                    number = 1;
                }
                encoded.Append(new string(decoded[i], number));
            }

            int allLines = 0;
            if (encoded.Length % maxSymbols == 0)
            {
                allLines = encoded.Length / maxSymbols;
            }
            else
            {
                allLines = encoded.Length / maxSymbols + 1;
            }

            int symbol = 0;
            int line = 1;
            int currentNum = 0;

            StringBuilder result = new StringBuilder();

            while (symbol < encoded.Length)
            {
                result.AppendFormat("{0," + Convert.ToString(allLines).Length +"} ", line);
                for (int i = 0; i < maxSymbols; i++)
                {
                    result.Append(encoded[symbol]);
                    symbol++;
                    currentNum++;
                    if (symbol == encoded.Length)
                    {
                        break;
                    }
                    if (currentNum == sequence && i < maxSymbols - 1)
                    {
                        result.Append(" ");
                        currentNum = 0;
                    }
                }
                line++;
                currentNum = 0;
                result.AppendLine();
            }

            Console.Write(result);
        }
    }
}
