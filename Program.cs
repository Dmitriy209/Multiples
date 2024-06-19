using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int divider = random.Next(10, 25);

            int startCycle = 50;
            int endCycle = 150;
            int quantityMultiples = 0;

            for (int i = startCycle; i <= endCycle; i++)
            {
                int Multiples = i;

                while (Multiples > divider)
                {
                    Multiples -= divider;
                }

                if (Multiples == divider)
                {
                    quantityMultiples++;
                }
            }

            Console.WriteLine($"В диапазоне от {startCycle} до {endCycle} найдено {quantityMultiples} чисел кратных {divider}");
        }
    }
}
