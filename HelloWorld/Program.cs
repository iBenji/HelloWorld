using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Sum: {a + b}");
        Console.WriteLine($"Difference: {a - b}");
        Console.WriteLine($"Product: {a * b}");
        Console.WriteLine($"Quotient: {a / b}");
    }
}