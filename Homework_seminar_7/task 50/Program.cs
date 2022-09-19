// Задача 50. Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, 
// и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
} 

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void FindNum(int[,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                Console.Write($"Число {num} встречается в элементе с индексами: [{i}, {j}] ");
                return;
            }
        }
    }
    Console.Write("Такого элемента нет");
}

Console.WriteLine("Введите число: ");
int NumForSearch = int.Parse(Console.ReadLine());

    int m = new Random().Next(1, 5);
    int n = new Random().Next(1, 5);
    int min = new Random().Next(0, 1);
    int max = new Random().Next(1, 10);

int[,] myArray = GetArray(m, n, min, max);
PrintArray(myArray);

FindNum(myArray, NumForSearch);