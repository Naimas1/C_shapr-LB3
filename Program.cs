using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть шестизначне число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int reversedNumber = ReverseNumber(number);

        Console.WriteLine($"Результат: {reversedNumber}");

        Console.ReadLine();
    }

    static int ReverseNumber(int number)
    {
        int reversedNumber = 0;

        while (number > 0) 
        {
            int remainder = number % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            number /= 10;
        }

        return reversedNumber;
    }
}
