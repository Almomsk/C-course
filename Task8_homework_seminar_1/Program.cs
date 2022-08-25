// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
    
for (int i = 1; i <= N; i++)
    if (i % 2 == 0)
        Console.Write(i + " ");