using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість елементів у масиві: ");
        int n = int.Parse(Console.ReadLine());

        double[] array = new double[n];
        Console.WriteLine("Введіть елементи масиву:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Елемент {i + 1}: ");
            array[i] = double.Parse(Console.ReadLine());
        }

        double min = array[0];
        int lastMinIndex = 0;

        for (int i = 1; i < n; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                lastMinIndex = i;
            }
            else if (array[i] == min)
            {
                lastMinIndex = i;
            }
        }

        Console.WriteLine($"Останній мінімальний елемент: {min}");
        Console.WriteLine($"Його номер (індекс з 0): {lastMinIndex}");
        Console.WriteLine($"Його номер (з 1): {lastMinIndex + 1}");
    }
}
