// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void OddPositionElSum(int[] array)
{
    int OddPositionElSum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            OddPositionElSum = OddPositionElSum;
        }
        else
        {
            OddPositionElSum = OddPositionElSum + array[i];
        }
    }
    Console.WriteLine($"{OddPositionElSum}");
}

int[] myArray = GetArray(10, -10, 10);
Console.WriteLine(String.Join(" ", myArray));
OddPositionElSum(myArray); 