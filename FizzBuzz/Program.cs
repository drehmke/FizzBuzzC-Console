using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static public void evaluateExpression(int testInt, int divisor1, int divisor2, string string1, string string2)
        {
            string printMe = null;
            if( testInt % divisor1 == 0 )
            {
                printMe = string1;
            }
            if( testInt % divisor2 == 0)
            {
                printMe += string2;
            }

            if( printMe != null )
            {
                Console.WriteLine(printMe);
            } else
            {
                Console.WriteLine(testInt);
            }
        }

        static void Main(string[] args)
        {
            for( int i = 1; i <= 100; i++)
            {
                evaluateExpression(i, 3, 7, "Fizz", "Buzz");
            }
            Console.ReadLine();
        }
    }
}
