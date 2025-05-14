using System;

public class RowSum
{
    public static void Main(string[] args)
    {
        Console.Write("Введіть кількість рядків (n): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Некоректний ввід кількості рядків.");
            return;
        }

        // Припускаємо, що кількість елементів у кожному рядку однакова (m) для простоти.
        // Завдання формулює "до mj (j=1..n)", що може означати різну довжину рядків.
        // Для простоти реалізації візьмемо однакову довжину.
        Console.Write("Введіть кількість елементів у кожному рядку (m): ");
        int m;
        if (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
        {
            Console.WriteLine("Некоректний ввід кількості елементів у рядку.");
            return;
        }

        int[][] jaggedArray = new int[n][];
        Console.WriteLine($"Введіть елементи масиву {n}x{m}:");
        for (int i = 0; i < n; i++)
        {
            jaggedArray[i] = new int[m];
            Console.WriteLine($"Введіть елементи для рядка {i + 1}:");
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Елемент [{i + 1},{j + 1}]: ");
                if (!int.TryParse(Console.ReadLine(), out jaggedArray[i][j]))
                {
                    Console.WriteLine("Некоректний ввід цілого числа.");
                    return;
                }
            }
        }

        Console.Write("Введіть початковий номер елемента для суми (k1): ");
        if (!int.TryParse(Console.ReadLine(), out int k1) || k1 < 1)
        {
            Console.WriteLine("Некоректний ввід початкового номера.");
            return;
        }

        Console.Write("Введіть кінцевий номер елемента для суми (k2): ");
        if (!int.TryParse(Console.ReadLine(), out int k2) || k2 < k1 || k2 > m)
        {
            Console.WriteLine("Некоректний ввід кінцевого номера.");
            return;
        }

        int[] rowSums = new int[n];

        for (int i = 0; i < n; i++)
        {
            int currentSum = 0;
            for (int j = k1 - 1; j < k2; j++)
            {
                currentSum += jaggedArray[i][j];
            }
            rowSums[i] = currentSum;
        }

        Console.WriteLine("\nСуми елементів у кожному рядку (від номера k1 до k2):");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Сума рядка {i + 1}: {rowSums[i]}");
        }
    }
}