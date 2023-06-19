using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineComparision_Refactor
    {
        double xOne, xTwo, yOne, yTwo,xThree,yThree,xFour,yFour, line_Length,Second_line_Length ;
        public void Line()
        {
            Console.WriteLine("Please Enter x , y Co-ordinates of line ONE :");
            Console.WriteLine("Please Enter values of xOne and yOne");
            xOne = Convert.ToInt32(Console.ReadLine());
            yOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter values of xTwo and yTwo");
            xTwo = Convert.ToInt32(Console.ReadLine());
            yTwo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter x , y Co-ordinates of line ONE :");
                Console.WriteLine("Please Enter values of xThree and yThree");
                xThree = Convert.ToInt32(Console.ReadLine());
                yThree = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter values of xFour and yFour");
                xFour = Convert.ToInt32(Console.ReadLine());
                yFour= Convert.ToInt32(Console.ReadLine());

                line_Length = Math.Sqrt(Math.Pow((xTwo - xOne), 2) + Math.Pow((yTwo - yOne), 2));
                Console.WriteLine("Length of the line ONE is : " + line_Length);

            

            Second_line_Length  = Math.Sqrt(Math.Pow((xFour - xThree), 2) + Math.Pow((yFour - yThree), 2));
            Console.WriteLine("Length of the line Two is : " +  Second_line_Length);

            if (line_Length == Second_line_Length)
            {
                Console.WriteLine("Two lines are equal");
            }
            else if (line_Length.CompareTo(Second_line_Length) < 0)
            {
                Console.WriteLine("line_One is less than Line_Two");
            }
            else
            {
                Console.WriteLine("Line_One is Greater Than Line_Two");
            }

        }
    }
}
