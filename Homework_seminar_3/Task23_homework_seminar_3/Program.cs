// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.​
// 3 -> 1, 4, 27. ​
// 5 -> 1, 8, 27, 64, 125

int N = ReadInt("Введите произвольное число: ");

for (int i = 1; i <= N; i++)
{ 
    Console.Write($"{i*i*i} ");
}
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}