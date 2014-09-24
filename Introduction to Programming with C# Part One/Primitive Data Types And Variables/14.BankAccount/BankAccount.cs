using System;

namespace _14.BankAccount
{
    class BankAccount
    {
        static void Main()
        {
            Console.WriteLine("Please, enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please, enter your middle name: ");
            string middleName = Console.ReadLine();
            Console.WriteLine("Please, enter your fimaly name: ");
            string familyName = Console.ReadLine();
            Console.WriteLine("Please, enter the amount of money you have: ");
            int amountOfMoney = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter your bank name: ");
            string bankName = Console.ReadLine();
            Console.WriteLine("Please, enter your IBAN number: ");
            string IBAN = Console.ReadLine();
            Console.WriteLine("Please, enter your BIC number: ");
            string BIC = Console.ReadLine();
            Console.WriteLine("Please, enter your first credit card number: ");
            long creditCardNumber1 = long.Parse(Console.ReadLine());             // For the credit card numbers we can use also string because we 
            Console.WriteLine("Please, enter your second credit card number: "); // are not going to change the numbers but only use them as a whole.
            long creditCardNumber2 = long.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter your third credit card number: ");
            long creditCardNumber3 = long.Parse(Console.ReadLine());
            Console.WriteLine("The information you have typed is respectively: ");
            Console.WriteLine("string");
            Console.WriteLine("string");
            Console.WriteLine("string");
            Console.WriteLine("int");
            Console.WriteLine("string");
            Console.WriteLine("string");
            Console.WriteLine("string");
            Console.WriteLine("int");
            Console.WriteLine("int");
            Console.WriteLine("int");
        }
    }
}
