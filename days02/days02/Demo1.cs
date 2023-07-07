using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    Define a variable called name with your Name as the assigned value
    Print the value stored in the variable name
    Change the variable to store your father's name
    Print the value stored in the variable name
    Change the variable again to store your mother's name.
    Print the value stored in the variable name
 */

namespace days02
{
    public class Demo1
    {

        public static void Main(string[] args)
        {
            String name = "Nitish";
            String fName = "Hiralal mukhiya";
            int age = 23;
            int roll = 25;
            int mark = 234;

            Console.WriteLine("MY Name is" + name+ "My father Name"+fName);
            Console.WriteLine("Age "+age+ "Roll"+roll+"Marks is: "+mark);
        }
    }
}
