// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.​
// [1,0,1,1,0,1,0,0]

int [] initArray()
{
    int[] arr = new int[8];
    for(int i=0; i<arr.Length;i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

void ReadArray(int [] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

ReadArray(initArray());

Console.WriteLine(String.Join(", ", initArray()));