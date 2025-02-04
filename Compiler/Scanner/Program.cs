using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] array = new int[15];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 15);
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(array);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = 0;
            }
        }

        // Выводим измененный массив
        Console.WriteLine("Измененный массив:");
        PrintArray(array);
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
