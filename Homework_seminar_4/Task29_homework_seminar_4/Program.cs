// Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19] ​
// 3, 1, 35 -> [6, 1, 33]

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int InitArray = ReadInt("Введите длинну массива: ");

Console.WriteLine("Введите число a, соответствующее возможному наименьшему из массива: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b, соответствующее возможному наибольшему из массива: ");

int b = int.Parse(Console.ReadLine());
int[] randomArray = new int[InitArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(a, b);
    Console.Write(randomArray[i] + " ");
}


