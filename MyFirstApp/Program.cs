
public class MyFirstApp
{
    

    public static void Main()
    {
        //Your task: Create a program that swaps two variables

        int number1 = 12;
        int number2 = 8;

        int temp1 = 0;
        int temp2 = 0;

        temp1 = number1;
        temp2 = number2;

        number1 = temp2;
        number2 = temp1;

        Console.WriteLine("first number is now: " + number1);
        Console.WriteLine("second number is now: " + number2);

    }

}


