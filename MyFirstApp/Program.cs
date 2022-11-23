using System;

namespace HelloWorld


{
    class Program
    {


        static void Main(string[] args)

        {
            Console.WriteLine(Calculate());
            Console.Read();
        }

        public static int Calculate()
        {

            Console.WriteLine("Please enter num1");
            string num1Input = Console.ReadLine();

            Console.WriteLine("Please enter num2");
            string num2Input = Console.ReadLine();

            int num1 = int.Parse(num1Input);
            int num2 = int.Parse(num2Input);


            int result = num1 + num2;
            return result;
        }
   
    }
}

