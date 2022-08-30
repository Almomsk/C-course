// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int Number = int.Parse(Console.ReadLine());
if (Number % 2 == 1)
{
    Console.WriteLine("Число " + Number + " является: Нечётным");
}
else
{
    Console.WriteLine("Число " + Number + "является: Чётным");
}