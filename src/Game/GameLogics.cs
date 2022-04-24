using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class GameLogics
    {

        public void GenerateNumber()
        {
            for (int i = 0; i < 50; i++)
            {
                CheckNumber(i);
            }
        }

        public void CheckNumber(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if ( number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
        }
    }
}
