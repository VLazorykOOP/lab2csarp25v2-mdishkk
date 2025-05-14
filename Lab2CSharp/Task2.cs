using System;

public class LastMinimumElement
{
    public static void Main(string[] args)
    {
        Console.Write("Введіть розмірність масиву (n): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Некоректний ввід розмірності масиву.");
            return;
        }

        double[] numbers = new double[n];
        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Елемент [{i}]: ");
            if (!double.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("Некоректний ввід числа.");
                return;
            }
        }

        if (n == 0)
        {
            Console.WriteLine("Масив порожній, мінімального елемента не знайдено.");
            return;
        }

        double minElement = numbers[0];
        int lastMinIndex = 0;

        for (int i = 1; i < n; i++)
        {
            if (numbers[i] <= minElement)
            {
                minElement = numbers[i];
                lastMinIndex = i;
            }
        }

        Console.WriteLine($"Останній мінімальний елемент: {minElement}");
        Console.WriteLine($"Номер (індекс) останнього мінімального елемента: {lastMinIndex}");
    }
}