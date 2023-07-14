using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace days03
{
    public class Class1
    {
        public static void findOdd(int x)
        {
            if (x % 2==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        public static void Main(String[] args)
        {

            int x = 7;

            findOdd(x);

        }

    }
}
