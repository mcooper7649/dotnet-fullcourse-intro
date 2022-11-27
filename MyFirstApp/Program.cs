using System;
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare 2d array
            string[,] matrix;

            //Decalry 3d array
            int[,,] threeD;

            //two dimensional array
            int[,] array2d = new int[,]
            {
                {
                    1,2,3
                },
                {
                    4,5,6
                },
                {
                    7,8,9
                },


            };
            Console.WriteLine("Central value is {0}", array2d[2, 0]);


            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"},
                    {"Hi There", "What's Up"}
                },
                {
                    {"100", "101"},
                    {"110", "111" },
                    {"I'm Good", "and u?" }
                }
            };

            string[,] array2dString = new string[3, 2]
            {
                {"one", "two" },
                {"three", "four" },
                {"five", "six" }
            };

            array2dString[1, 1] = "Chicken";

            int dimensions = array2d.Rank;

            int[,] array2d2 = { { 1, 2 } ,  { 3 , 4 } };



            Console.WriteLine("The value is {0}", dimensions);
            Console.ReadKey();
        }

    }

}