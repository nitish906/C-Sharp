using System;

namespace Nitish;

public class LogicalOperators
{
     public static void find(int a)
    {
        if(a%3==0 && a % 5 == 0)
        {
            Console.WriteLine("The number"+ a +"is divisible by 3 or 5.");
        }
        else
        {
            Console.WriteLine("The number "+" "+ a +" "+ " is not divisible by 3 or 5.");
        }

        /*
         *  Enter a number:
            15
            The number 15 is divisible by 3 or 5.
         * 
         */
    }

    public static void Main(string[] args)
    {
        int a;
        Console.WriteLine("Enter a number: ");
        a= Convert.ToInt32(Console.ReadLine());


        find(a);
    }
}
