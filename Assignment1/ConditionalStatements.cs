using System;

namespace Nitish;

public class ConditionalStatements
{
    public static void find(int num)
    {
        if (num > 0)
        {
            Console.WriteLine("The number " + num + " is positive.");
        }
        else if (num < 0)
        {
            Console.WriteLine("The number " + num + " is negative.");
        }
        else
        {
            Console.WriteLine("The number " + num + " is zero.");
        }

        /*
         *  Enter a number:
            2
            The number 2 is positive.
         * 
         */
    }

    public static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Enter a number: ");
        num= Convert.ToInt32(Console.ReadLine());


        find(num);
    }
}
