using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть розмір масиву: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Елемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Введіть нижню межу інтервалу: ");
        int lower = int.Parse(Console.ReadLine());

        Console.Write("Введіть верхню межу інтервалу: ");
        int upper = int.Parse(Console.ReadLine());

        int count = 0;
        foreach (int element in array)
        {
            if (element < lower || element > upper)
                count++;
        }

        Console.WriteLine($"Кількість елементів, що не входять в інтервал [{lower}; {upper}]: {count}");
    }
}

    
