using System;

namespace _13.Exchange345With242526
{
    class Exchange345With242526
    {
        static void Main()
        {
            string number = null;
            Console.WriteLine("Please, enter a number: ");
            number = Console.ReadLine();
            uint intNumber = uint.Parse(number);
            Console.WriteLine("Your number is: " + intNumber);

            //changing 3 <=> 24 bits
            uint mask3 = 1 << 3;
            uint result3 = intNumber & mask3;
            result3 >>= 3;
            uint mask24 = 1 << 24;
            uint result24 = intNumber & mask24;
            result24 >>= 24;
            if (result24 == 1)
            {
                intNumber |= mask3;
            }
            else
            {
                intNumber &= (~mask3);
            }
            if (result3 == 1)
            {
                intNumber |= mask24;
            }
            else
            {
                intNumber &= (~mask24);
            }

            //changing 4 <=> 25 bits
            uint mask4 = 1 << 4;
            uint result4 = intNumber & mask4;
            result4 >>= 4;
            uint mask25 = 1 << 25;
            uint result25 = intNumber & mask25;
            result25 >>= 25;
            if (result25 == 1)
            {
                intNumber |= mask4;
            }
            else
            {
                intNumber &= (~mask4);
            }
            if (result4 == 1)
            {
                intNumber |= mask25;
            }
            else
            {
                intNumber &= (~mask25);
            }

            //changing 5 <=> 26 bits
            uint mask5 = 1 << 5;
            uint result5 = intNumber & mask5;
            result5 >>= 5;
            uint mask26 = 1 << 26;
            uint result26 = intNumber & mask26;
            result26 >>= 26;
            if (result26 == 1)
            {
                intNumber |= mask5;
            }
            else
            {
                intNumber &= (~mask5);
            }
            if (result5 == 1)
            {
                intNumber |= mask26;
            }
            else
            {
                intNumber &= (~mask26);
            }

            Console.WriteLine("With exchanged bits: " + intNumber);
        }
    }
}