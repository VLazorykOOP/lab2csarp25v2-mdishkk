using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть розмірність матриці n (матриця буде n x n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        Console.WriteLine("Введіть елементи матриці:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"[{i + 1},{j + 1}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("Введіть степінь, у яку потрібно піднести матрицю (натуральне число): ");
        int power = int.Parse(Console.ReadLine());

        int[,] result = MatrixPower(matrix, n, power);

        Console.WriteLine($"\nРезультат піднесення матриці до степеня {power}:");
        PrintMatrix(result, n);
    }

    static int[,] MatrixPower(int[,] matrix, int size, int power)
    {
        // Починаємо з одиничної матриці
        int[,] result = IdentityMatrix(size);

        for (int p = 0; p < power; p++)
        {
            result = MultiplyMatrices(result, matrix, size);
        }

        return result;
    }

    static int[,] IdentityMatrix(int size)
    {
        int[,] identity = new int[size, size];
        for (int i = 0; i < size; i++)
            identity[i, i] = 1;
        return identity;
    }

    static int[,] MultiplyMatrices(int[,] a, int[,] b, int size)
    {
        int[,] result = new int[size, size];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                int sum = 0;
                for (int k = 0; k < size; k++)
                {
                    sum += a[i, k] * b[k, j];
                }
                result[i, j] = sum;
            }
        }
        return result;
    }

    static void PrintMatrix(int[,] matrix, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

