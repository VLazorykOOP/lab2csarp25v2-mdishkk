using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість рядків (n): ");
        int n = int.Parse(Console.ReadLine());

        int[][] jaggedArray = new int[n][];

        // Введення східчастого масиву
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть кількість елементів у рядку {i + 1}: ");
            int m = int.Parse(Console.ReadLine());
            jaggedArray[i] = new int[m];

            for (int j = 0; j < m; j++)
            {
                Console.Write($"[{i + 1},{j + 1}]: ");
                jaggedArray[i][j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("Введіть початковий індекс k1 (починаючи з 0): ");
        int k1 = int.Parse(Console.ReadLine());

        Console.Write("Введіть кінцевий індекс k2 (починаючи з 0): ");
        int k2 = int.Parse(Console.ReadLine());

        int[] sums = new int[n];

        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = k1; j <= k2 && j < jaggedArray[i].Length; j++)
            {
                sum += jaggedArray[i][j];
            }
            sums[i] = sum;
        }

        Console.WriteLine("\nСума елементів з індексами від k1 до k2 для кожного рядка:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Рядок {i + 1}: {sums[i]}");
        }
    }
}

