using System;

public class MatrixPower
{
    public static double[,] MultiplyMatrices(double[,] matrixA, double[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int rowsB = matrixB.GetLength(0);
        int colsB = matrixB.GetLength(1);

        if (colsA != rowsB)
        {
            throw new ArgumentException("Кількість стовпців першої матриці повинна дорівнювати кількості рядків другої.");
        }

        double[,] result = new double[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                double sum = 0;
                for (int k = 0; k < colsA; k++)
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }
                result[i, j] = sum;
            }
        }

        return result;
    }

    public static double[,] Power(double[,] matrix, int exponent)
    {
        int size = matrix.GetLength(0);
        if (size != matrix.GetLength(1))
        {
            throw new ArgumentException("Матриця повинна бути квадратною для піднесення до степеня.");
        }
        if (exponent < 0)
        {
            throw new ArgumentException("Степінь повинен бути невід'ємним цілим числом.");
        }
        if (exponent == 0)
        {
            double[,] identity = new double[size, size];
            for (int i = 0; i < size; i++)
            {
                identity[i, i] = 1;
            }
            return identity;
        }
        if (exponent == 1)
        {
            return matrix;
        }

        double[,] result = matrix;
        for (int i = 2; i <= exponent; i++)
        {
            result = MultiplyMatrices(result, matrix);
        }

        return result;
    }

    public static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        Console.Write("Введіть розмірність квадратної матриці (n): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Некоректний ввід розмірності.");
            return;
        }

        double[,] matrix = new double[n, n];
        Console.WriteLine($"Введіть елементи матриці {n}x{n}:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Елемент [{i},{j}]: ");
                if (!double.TryParse(Console.ReadLine(), out matrix[i, j]))
                {
                    Console.WriteLine("Некоректний ввід числа.");
                    return;
                }
            }
        }

        Console.Write("Введіть натуральний степінь (n): ");
        if (!int.TryParse(Console.ReadLine(), out int exponent) || exponent < 0)
        {
            Console.WriteLine("Некоректний ввід степеня.");
            return;
        }

        double[,] resultMatrix = Power(matrix, exponent);

        Console.WriteLine($"\nМатриця в степені {exponent}:");
        PrintMatrix(resultMatrix);
    }
}