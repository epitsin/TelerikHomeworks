using System;

namespace _3.CompanyManager
{
    class CompanyManager
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the name of the company: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please, enter the address of the company: ");
            string address = Console.ReadLine();
            Console.WriteLine("Please, enter the number of the company: ");
            long number = 0L;
            while (true)
            {
                string str1 = Console.ReadLine();
                if (long.TryParse(str1, out number))
                {
                    break;
                }

            }
            Console.WriteLine("Please, enter the website of the company: ");
            string website = Console.ReadLine();
            Console.WriteLine("Please, enter the first name of the manager: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please, enter the last name of the manager: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please, enter the age of the manager: ");
            ushort age = 0;
            while (true)
            {
                string str2 = Console.ReadLine();
                if (ushort.TryParse(str2, out age))
                {
                    break;
                }

            }
            Console.WriteLine("Please, enter the mobile phone number of the manager: ");
            long mobile = 0L;
            while (true)
            {
                string str3 = Console.ReadLine();
                if (long.TryParse(str3, out mobile))
                {
                    break;
                }

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0,-20} | {1,20} |", "Company", "Manager");
            Console.WriteLine(new string('-', 45));
            Console.WriteLine("{0,-20} | {1,20} |", name, firstName);
            Console.WriteLine("{0,-20} | {1,20} |", address, lastName);
            Console.WriteLine("{0,-20} | {1,20} |", number, mobile);
            Console.WriteLine("{0,-20} | {1,20} |", website, age);
      
         
        }
    }
}
