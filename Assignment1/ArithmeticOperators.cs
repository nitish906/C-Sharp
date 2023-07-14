using System;

namespace Nitish;

public class ArithmeticOperators
{
    public static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Enter Number a: ");
        a= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Number b: ");
        b= Convert.ToInt32(Console.ReadLine());

        int sum = a + b;
        Console.WriteLine("Addition: " + sum);

        /*
         * output:
         Enter Number a:
         10
         Enter Number b:
         5
         Addition: 15 */

        int sub = a - b;
        Console.WriteLine("Subtraction: " + sub);

        /*
         * output:
         Enter Number a:
         10
         Enter Number b:
         5
         Subtraction: 5 */

        int mul = a * b;
        Console.WriteLine("Multiplication: " + mul);

        /*
         * output:
         Enter Number a:
         10
         Enter Number b:
         15
         Multiplication: 50 */



        int division = a / b;
        Console.WriteLine("Division: " + division);

        /*
         * output:
         Enter Number a:
         10
         Enter Number b:
         5
         Division: 2 */
    }
}
