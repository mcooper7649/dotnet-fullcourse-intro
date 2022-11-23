using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsC
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operators

            num3 = -num1;

            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("Is it Sunny? {0}", !isSunny);


            //increment operators
            int num = 0;
            num++;
            Console.WriteLine("Num is {0}", num);

            //post increment operator
            Console.WriteLine("Num is {0}", num++);

            //pre increment operator
            Console.WriteLine("Num is {0}", ++num);

            //Decrement operator
            num--;
            Console.WriteLine("Num is {0}", num--);

            //Post decrement operator
            Console.WriteLine("Num is {0}", num--);


            //pre increment operator
            Console.WriteLine("Num is {0}", --num);


            int result;
            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);

            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);

            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result);

            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);

            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result);


            //relational and type operators

            bool isLower;

            isLower = num1 > num2;

            Console.WriteLine("result of num1 < num2 is {0}", isLower);



            //equality operator

            bool isEqual;

            isEqual = num1 == num2;

            Console.WriteLine("result of num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);


            //Conditional Operators

            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny;

            Console.WriteLine("result of isLower && isSunny {0}", isLowerAndSunny);

            Console.ReadKey();








        }
    }
}


