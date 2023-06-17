using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class ComparisonLine
    {
        double x1, x2, y1, y2,  line_Length;
        public void Lines()
        {
            Console.WriteLine("Please Enter x , y Co-ordinates of line 1 :");
            Console.WriteLine("Please Enter values of x1 and y1");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter values of x2 and y2");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

           
            line_Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of the line 1 is : " + line_Length);



        }
    }
}
