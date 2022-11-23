
public class MyFirstApp
{
    static float vat = 13f;

    public static void Main()
    {
        float productA = 3.99f;
        float productB = 11.88f;
        float productC = 4.74f;

        float summed = productA + productB + productC;
        float totalTax = (summed / 100) * vat;
        summed += totalTax;
        Console.WriteLine("Total Price is: " + summed);
    }

    public static void Calculate()
    {
        Console.WriteLine("Vat is " + vat);
    }
}


