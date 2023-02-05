using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Length length = new Length(4, 8, 3, 5);
            length.Calculate();

            // UC2

            LineEquality length_Two = new LineEquality(5, 6, 7, 8);
            double length_ = length_Two.Calculate();

            if (length.Equals(length_))
                Console.WriteLine("Both lines are equal");
            else
                Console.WriteLine("Both lines are not equal");

            Console.ReadLine();
        }
    }
}
