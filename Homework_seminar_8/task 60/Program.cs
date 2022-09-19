// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetArray(int m, int n, int k)
{
    int[,,] result = new int[m, n, k];
    int digit = 10;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int y = 0; y < k; y++)
            {
                result[i, j, y] += digit;
                digit += 5;
            }

        }
    }

    return result;
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int y = 0; y < array.GetLength(2); y++)
            {
                Console.Write($"{array[i, j, y]} ({i}, {j}, {y})\t ");
            }

        }
        Console.WriteLine();
    }
}

int[,,] myArray = GetArray(2, 2, 2);
PrintArray(myArray);
