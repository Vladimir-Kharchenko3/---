using System;

class Program
{
    static void Main()
    {
        int[] numbers = GenerateRandomArray(6, 1, 10); // Генерация случайного массива

        // Вывод исходного массива
        Console.Write("Исходный массив: ");
        PrintArray(numbers);

        // Реверсирование массива с использованием метода Array.Reverse
        Array.Reverse(numbers);

        // Вывод измененного массива
        Console.Write("\nПеревернутый массив: ");
        PrintArray(numbers);
    }

    // Метод для генерации случайного массива
    static int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        Random random = new Random();
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }

        return array;
    }

    // Метод для вывода массива
    static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
    }
}