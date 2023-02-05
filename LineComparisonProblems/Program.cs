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

            //UC3

            CompareLines Length2 = new CompareLines(9, 1, 2, 3);
            double _Length = Length2.Calculate();

            CompareLines Length3 = new CompareLines(4, 5, 6, 7);
            double Length = Length3.Calculate();


            if (_Length.CompareTo(Length2) == 0)
                Console.WriteLine("Equal");


            else if (Length.CompareTo(Length2) > 0)

                Console.WriteLine("Line one is greater");
            else
                Console.WriteLine("Line two is greater");
            Console.ReadKey();

        }

        
        }
    }

