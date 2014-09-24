using System;

namespace CoffeeMachine
{
    class CoffeeMachine
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            double machineMoney = array[0] * 0.05 + array[1] * 0.1 + array[2] * 0.2 + array[3] * 0.5 + array[4] * 1;
            double money = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            if (money >= price && machineMoney >= (money - price))
            {
                Console.WriteLine("Yes {0:0.00}", machineMoney - money + price);
            }
            else if (money < price)
            {
                Console.WriteLine("More {0:0.00}", price - money);
            }
            else if (money >= price && machineMoney < (money - price))
            {
                Console.WriteLine("No {0:0.00}", money - price - machineMoney);
            }
        }
    }
}
