using System;

namespace Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowLimitRandom = 10;
            int highLimitRandom = 25;
            
            Random random = new Random();
            int divider = random.Next(lowLimitRandom, highLimitRandom);

            int startCycle = 50;
            int endCycle = 150;
            int quantityMultiples = 0;

            for (int i = 0; i <= endCycle; i += divider)
            {
                if (i >= startCycle)
                {
                    quantityMultiples++;
                }
            }

            Console.WriteLine($"В диапазоне от {startCycle} до {endCycle} найдено {quantityMultiples} чисел кратных {divider}");
        }
    }
}
