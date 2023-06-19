using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the line comparision Program");
            ComparisonLine comparisonLine = new ComparisonLine();
            comparisonLine.Lines();

            //Refactor
            LineComparision_Refactor lineComparision_Refactor = new LineComparision_Refactor();
            lineComparision_Refactor.Line();
            Console.ReadLine();
        }
    }
}
