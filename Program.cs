//-by Mustafa DESTECI
using System;
using System.Collections.Generic;

namespace The_Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            List<int> lottery = new List<int>();
            Random random = new Random();
            int number;
            int counter = 0;

            number = random.Next(1, 50);
            lottery.Add(number);
            Console.WriteLine(" First number in lottery: "+lottery[0] + "\n");

            for (int i = 0; i < 5; i++)
            {
                number = random.Next(1, 50);
                for (int j = 0; j < lottery.Count; j++)
                {
                    //Üretilen sayilar birbirine eşit mi kontrolü
                    if (number == lottery[j])
                    {
                        counter++;
                        break;
                    }
                }
                if (counter == 0)
                {
                    lottery.Add(number);
                }
                else
                {
                    i--;
                }
            }
            
            Console.WriteLine(" LOTTERY\n");
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(" "+(i + 1) + ")-" + lottery[i]);
            }

            Console.ReadKey();
        }
    }
}
