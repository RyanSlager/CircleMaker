using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleMaker
{
    class Validator
    {
        static Validator()
        {
            
        }

        public static double CheckDubs(string x)
        {
            double z;
            string y = x;

            while(! double.TryParse(y, out z) || z <= 0)
            {
                Console.WriteLine("That is not a valid input, please enter a positive number\n");
                y = Console.ReadLine();
            }

            return z;
        }
    }
}
