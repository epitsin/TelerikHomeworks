using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExceptionHandling
{
    class SquareNumber
    {
        static void Main()
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    throw new FormatException();
                }
                Console.WriteLine(Math.Sqrt(n));
            }
            catch (System.ArgumentNullException fe)
            {
                Console.WriteLine("Invalid number: " + fe.Message);
            }

            catch (System.OverflowException fe)
            {
                Console.WriteLine("Invalid number: " + fe.Message);
            }

            catch (System.FormatException fe)
            {
                Console.WriteLine("Invalid number: " + fe.Message);
            }

            catch (System.Exception)
            {
                Console.WriteLine("Invalid number!");
            }

            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
