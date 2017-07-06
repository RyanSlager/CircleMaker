using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleMaker
{
    class Circle
    {
        private double radius;

        public Circle()
        {
            this.radius = SetRadius();
        }

        public double SetRadius()
        {
            Console.WriteLine("Please enter the radius of your circle: \n");
            string x = Console.ReadLine();
            double y = Validator.CheckDubs(x);

            return y;
        }
        public double GetArea()
        {
            double area = Math.PI*(radius * radius);

            return area;
        }

        public double GetCircum()
        {
            double circum = 2 * Math.PI * radius;

            return circum;
        }

        public string GetRoundedArea(double area)
        {
            double roundArea = Math.Round(area, 2);
            string formattedArea = $"Area:          {roundArea}";
            return formattedArea;
        }

        public string GetRoundedCircum(double circumference)
        {
            double circum = Math.Round(circumference, 2);
            string formattedCircum = $"Circumference: {circum}";

            return formattedCircum;
        }
    }
}
