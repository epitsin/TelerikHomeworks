using System;
using System.Text;

namespace DecodeAndDecrypt
{
    class DecodeAndDecrypt
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int cypherLength = 0;
            int c = input.Length - 1;
            int n = 0;
            int pow = 0;
            while(int.TryParse(input[c].ToString(), out n))
            {
                cypherLength += n * (int)Math.Pow(10, pow);
                pow++;
                c--;
            }
            StringBuilder cypher = new StringBuilder();
            for (int i = 0; i < cypherLength; i++)
            {
                n = 0;
                pow = 0;
                if (int.TryParse(input[c].ToString(), out n))
                {
                    int index = c;
                    int len = 0;
                    while (int.TryParse(input[index].ToString(), out n))
                    {
                        len += n * (int)Math.Pow(10, pow);
                        pow++;
                        index--;
                    }
                    for (int j = 0; j < len - 1; j++)
                    {
                        cypher.Insert(0, input[c + 1]);
                        i++;
                    }
                    i--;
                    c = index;
                }
                else
                {
                    cypher.Insert(0, input[c]);
                    c--;
                }
            }

            StringBuilder message = new StringBuilder();
            while(c >= 0)
            {
                n = 0;
                pow = 0;
                if (int.TryParse(input[c].ToString(), out n))
                {
                    int index = c;
                    int len = 0;
                    while (index >=0 && int.TryParse(input[index].ToString(), out n))
                    {
                        len += n * (int)Math.Pow(10, pow);
                        pow++;
                        index--;
                    }
                    for (int j = 0; j < len - 1; j++)
                    {
                        message.Insert(0, input[c + 1]);
                    }
                    c = index;
                }
                else
                {
                    message.Insert(0, input[c]);
                    c--;
                }
            }

            int p = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (cypher.Length <= message.Length)
                {
                    if (p >= cypher.Length)
                    {
                        p = 0;
                    }
                    int mesSym = (int)message[i] - 65;
                    int cyrSum = (int)cypher[p] - 65;
                    int result = mesSym ^ cyrSum;
                    message[i] = (char)(result + 65);
                    Console.Write(message[i]);
                    p++;
                }
                else if (cypher.Length > message.Length)
                {
                    int q = p;
                    while (q < cypher.Length)
                    {
                        int mesSym = (int)message[i] - 65;
                        int cyrSum = (int)cypher[q] - 65;
                        int result = mesSym ^ cyrSum;
                        message[i] = (char)(result + 65);
                        q += message.Length;
                    }
                    Console.Write(message[i]);
                    p++;
                }
            }
            Console.WriteLine();
        }
    }
}
