using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg35
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Please give me a number between 1 and 100.  Whole numbers only, please.");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(choice + " multiplied by 7 equals " + answerpg35.MathOne(choice));
            Console.WriteLine(choice + " plus 100 equals " + answerpg35.MathTwo(choice));
            Console.WriteLine(choice + " divided by 2 equals " + answerpg35.MathThree(choice));

            Console.ReadLine();









        }
    }

}
