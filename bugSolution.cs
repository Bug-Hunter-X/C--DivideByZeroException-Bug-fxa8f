public class ExampleClass
{
    public int Calculate(int a, int b)
    {
        try
        {
            return a / b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero.");
            return 0; // Or throw a custom exception
        }
    }
}