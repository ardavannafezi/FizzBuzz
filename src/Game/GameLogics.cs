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
               if(CheckNumber(i) == 0)
               {

               }
                
            }
        }

        public string CheckNumber(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                return "fizzbuzz";
            }
            else if (number % 3 == 0)
            {
                return "fizz";
            }
            else if (number % 5 == 0)
            {
                return "buzz";
            }

            else return "";
        }
    }
}
