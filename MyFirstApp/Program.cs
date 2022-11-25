using System;
namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.SetLength(-3);

            box.height = 4;
            box.width = 5;
            Console.WriteLine("box's volume is " + box.GetVolume());



            box.DisplayInfo();
        }

    }
}