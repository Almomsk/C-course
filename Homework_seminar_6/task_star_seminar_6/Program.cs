// Задача со "звездочкой":
// Напишите программу, которая реализует обход введенного двумерного массива, начиная с крайнего нижнего левого элемента против часовой стрелки.
//1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] myMatrix = new int[3, 3];


void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

int[] Obhod(int[,] myMatrix)
{
    int[] res = new int[9];
    int i = 0;
    int j = 0;
    int lowRow = myMatrix.GetLength(0) - 1;
    int highRow = 0;
    int lastCol = myMatrix.GetLength(1) - 1;
    int firstCol = 0;

    while (lowRow >= highRow && lastCol >= firstCol)
    {
        if (lowRow > highRow)
        {
            for (i = firstCol; i <= lastCol; i++)
            {
                res[j] = myMatrix[lowRow, i];
                j++;
            }
            lowRow--;
        }
        for (i = lowRow; i >= highRow; i--)
        {
            res[j] = myMatrix[i, lastCol];
            j++;
        }
        lastCol--;
        for (i = lastCol; i >= firstCol; i--)
        {
            res[j] = myMatrix[highRow, i];
            j++;
        }
        highRow++;
        if (firstCol < lastCol)
        {
            for (i = highRow; i <= lowRow; i++)
            {
                res[j] = myMatrix[i, firstCol];
                j++;
            }
            firstCol++;
        }    

    }
    return res;
}


FillMatrix(myMatrix);
PrintMatrix(myMatrix);
Console.WriteLine($"{String.Join(" ", Obhod(myMatrix))}");
