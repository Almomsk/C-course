// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] RowsSort(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int k = 0; k < row; k++)
    {
        for(int i = 0; i < col-1 ; i++)
        {
            int maxPosition = i;

            for (int j = i + 1; j < col; j++)
            {
                if(array[k, j] > array[k, maxPosition]) maxPosition = j;
            }
            int temporary = array[k, i];
            array[k, i] = array [k, maxPosition];
            array[k, maxPosition] = temporary;
        }
    }
    return array;
}

int[,] myArray = GetArray(4, 5, 0, 10);
PrintArray(myArray);
Console.WriteLine();

int[,] newArray = RowsSort(myArray);
PrintArray(newArray);
