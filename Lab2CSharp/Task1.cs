using System;

class Task1
{
    static void Main()
    {
        Console.Write("Введіть розмір одновимірного масиву: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Елемент [{i}] = ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Введіть нижню межу інтервалу: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Введіть верхню межу інтервалу: ");
        int max = int.Parse(Console.ReadLine());

        int count = 0;
        foreach (int num in array)
        {
            if (num < min || num > max)
                count++;
        }

        Console.WriteLine($"Кількість елементів поза інтервалом [{min}; {max}] = {count}");
    }
}
