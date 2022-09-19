// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    int num = 1;
    //int frame = 0; //perimetr
    for (int frame = 0; frame < n - 2; frame++) //идём по периметрам (рамкам)
    {

        int row = array.GetLength(0);
        int col = array.GetLength(1);
        for (int j = 0 + frame; j < n - frame; j++)
        {
            array[0 + frame, j] = num++;
        }
        for (int i = 1 + frame; i < m - frame; i++)
        {
            array[i, col - 1 - frame] = num++;
        }
        for (int j = col - 2 - frame; j > 0 + frame; j--)
        {
            array[row - 1 - frame, j] = num++;
        }
        for (int i = row - 1 - frame; i > 0 + frame; i--)
        {
            array[i, 0 + frame] = num++;
        }
    }

    return array;
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

int[,] myArray = GetArray(4, 4);
PrintArray(myArray);
Console.WriteLine();
