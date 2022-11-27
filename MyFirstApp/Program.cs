using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)

        {

            //declaring an ArrayList with undefined amount of object
            ArrayList myArrayList = new ArrayList();

            //declaring an arraylist with defined amout of object
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("hello");
            myArrayList.Add("Mike");
            myArrayList.Add(13.23);
            myArrayList.Add(128);
            myArrayList.Add(true);
            myArrayList.Add(4);



            myArrayList.Remove(25);
            myArrayList.Remove("hello");

            //delete element at specific position

            

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach (object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                } else if (obj is double)
                {
                    sum += (double)obj;
                } else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }

}