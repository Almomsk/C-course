// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.​
// 5 -> 1, 4, 9, 16, 25.​
// 2 -> 1,4

Console.WriteLine("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());
int count = 1;
while (count <= numberN)
{
    Console.Write($" {count*count}, ");
    count++;
}
Console.WriteLine();
for (int i = 1; i<= numberN; i++)
{
    Console.Write($"{i*i}, ");
    }  
Console.WriteLine();