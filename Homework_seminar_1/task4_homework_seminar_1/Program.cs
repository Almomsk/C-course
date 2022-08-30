// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите 3 числа:");
int Number1 = int.Parse(Console.ReadLine());
int Number2 = int.Parse(Console.ReadLine());
int Number3 = int.Parse(Console.ReadLine());
int max = Number1;
if (Number2 > max)
{
    max = Number2;
}
if (Number3 > max)
{
    max = Number3;
}
Console.WriteLine("Наибольшее из введённых чисел - " + max);