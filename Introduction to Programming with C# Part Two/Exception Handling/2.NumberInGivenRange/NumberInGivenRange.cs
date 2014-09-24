using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.NumberInGivenRange
{
    class NumberInGivenRange
    {
        static void NumberInRange(int start, int finish, int n)
        {
            if (n < start || n > finish)
            {
                throw new ArgumentOutOfRangeException("The number is either outside the range [start, finish] or is smaller than the previous number you entered!");
            }
        }

        static void Main()
        {
            try
            {
                int start = int.Parse(Console.ReadLine());
                int finish = int.Parse(Console.ReadLine());
                if (finish < start)
                {
                    throw new ArgumentException("Start is bigger than finish!");
                }

                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        int n = int.Parse(Console.ReadLine());
                        NumberInRange(start, finish, n);
                        start = n;
                    }
                    catch (OverflowException fe)
                    {
                        Console.WriteLine("Invalid number: " + fe.Message);
                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine("Invalid number: " + fe.Message);
                    }
                    catch (ArgumentOutOfRangeException fe)
                    {
                       Console.WriteLine(fe.ParamName);
                    }
                    catch (Exception fe)
                    {
                        Console.WriteLine("{0} - {1}", fe.GetType(), fe.Message);
                    }
                }
            }
            catch (ArgumentException fe)
            {
                Console.WriteLine(fe.ParamName);
            }
            
        }
    }
}
