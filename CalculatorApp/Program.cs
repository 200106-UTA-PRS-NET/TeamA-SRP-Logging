using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CalculatorLib math = new CalculatorLib();
            Console.WriteLine($"Sum of a group of numbers: {math.DoMath("add", 4.2, 3.6, 4.7)}");
            Console.WriteLine($"Multiplicand of a group of numbers: {math.DoMath("multiply", 3,4,5)}");
            Console.WriteLine($"Subtracting 10-4: {math.DoMath("subtract", 10,4)}");
            Console.WriteLine($"Dividing 12/3: {math.DoMath("divide",12,3)}");
            Console.WriteLine($"Using Subtract with 3 numbers: {math.DoMath("subtract", 12,3,4)}");
            Console.WriteLine($"Using Divide with 3 numbers: {math.DoMath("divide", 12, 3, 4)}");
            Console.WriteLine($"Using div as operation: {math.DoMath("div",12,3)}");

        }
    }
}
