using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineComparision_Refactor
    {
        double xOne, xTwo, yOne, yTwo, line_Length ;
        public void Line()
        {
            Console.WriteLine("Please Enter x , y Co-ordinates of line ONE :");
            Console.WriteLine("Please Enter values of xOne and yOne");
            xOne = Convert.ToInt32(Console.ReadLine());
            yOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter values of xTwo and yTwo");
            xTwo = Convert.ToInt32(Console.ReadLine());
            yTwo = Convert.ToInt32(Console.ReadLine());

            line_Length = Math.Sqrt(Math.Pow((xTwo - xOne), 2) + Math.Pow((yTwo - yOne), 2));
            Console.WriteLine("Length of the line ONE is : " + line_Length);

        }
    }
}
