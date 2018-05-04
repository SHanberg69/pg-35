using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a class. In that class, create three methods, each of which will take one integer parameter in and 
//return an integer.The methods should do some math operation on the received parameter.
//                                Put this class in a separate.cs file in the application.

//2. In the Main() program, ask the user what number they want to do the math operations on.

//3. Call each method in turn, passing the user input to the method.Display the returned integer to the screen.

namespace Pg35
{
    public class answerpg35
    {
   
        
            public static int MathOne (int choice)
            {
                int result1 = choice * 7;
                return result1;
            }

            public static int MathTwo(int choice)
            {
                int result2 = choice + 100;
                return result2;
            }

            public static int MathThree(int choice)
            {
                int result3 = choice / 2;
                return result3;
            }






    }
}
