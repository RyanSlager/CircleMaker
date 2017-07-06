using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            int count = 0;
            Console.WriteLine("Welcome to the circle maker!");
        
            while(cont == true)
            {
                Circle circ = new Circle();

                double area = circ.GetArea();
                double circum = circ.GetCircum();

                Console.WriteLine(circ.GetRoundedArea(area));
                Console.WriteLine(circ.GetRoundedCircum(circum));

                count++;
                cont = Continue();
            }
            if(cont == false)
            {
                string bye = CircleCount(count);
                Console.WriteLine(bye);
                return;
            }

        }

        private static string CircleCount(int count)
        {
            string c;
            if(count == 1)
            {
                c = "circle";
            }
            else
            {
                c = "circles";
            }
            string bye = $"Goodbye. You have made {count} {c}. " ;

            return bye;
        }

        public static bool Continue()
        {
            // user is prompted for confirmation to continue or quit
            string answer;
            bool cont;

            Console.WriteLine("Continue?\ny/n");
            answer = Console.ReadLine();

            while (answer != "y" && answer != "Y" && answer != "n" && answer != "N")
            {
                Console.WriteLine("Invalid entry.\nPlease enter y to continue or n to quit.\n");
                answer = Console.ReadLine();
            }

            if (answer == "n" || answer == "N")
            {
                cont = false;
                return cont;
            }
            else
            {
                cont = true;
                return cont;
            }
        }
    }
}
