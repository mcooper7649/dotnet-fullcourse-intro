using System;
namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3,4,5);
            //box.SetLength(4);

            //box.Height = -4;
            //box.Width = 4;
            Console.WriteLine("Box's width is " + box.Width);
            box.Width = 10;
            Console.WriteLine("Box's width is " + box.Width);

            Console.WriteLine("box's volume is " + box.Volume);



            box.DisplayInfo();
        }

    }
}