using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);

            }
            catch (FormatException)
            {
                throw;
                //Console.WriteLine("Format Exception, please enter the correct type next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Null Arg Exception");
            }finally
            {
                Console.WriteLine("This is called with error or success at the end");
            }

            Console.ReadKey();
        }
    }
}



