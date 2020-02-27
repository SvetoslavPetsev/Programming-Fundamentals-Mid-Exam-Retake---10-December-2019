using System;

namespace _01._Disneyland_Journey
{
    class Program
    {
        static void Main()
        {
            double jurneyCost = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            double savedMoney = 0;
            savedMoney += jurneyCost * 0.25;
            for (int i = 2; i <= months; i++)
            {
                if (i % 2 != 0)
                {
                    savedMoney -= savedMoney * 0.16;
                }
                if (i % 4 == 0)
                {
                    savedMoney += savedMoney * 0.25;
                }
                savedMoney += jurneyCost * 0.25;
            }
            double moneyForSouvenirs = savedMoney - jurneyCost;
            if (moneyForSouvenirs > 0)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {moneyForSouvenirs:F2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {Math.Abs(moneyForSouvenirs):F2}lv. more.");
            }
        }
    }
}
