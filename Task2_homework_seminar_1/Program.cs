// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Введите первое число: ");
int Number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int Number2 = int.Parse(Console.ReadLine());
if (Number1 > Number2)
{
    Console.WriteLine("Первое число " + Number1 + " больше чем второе " + Number2);
}
else
{
    Console.WriteLine("Второе число " + Number2 + " больше чем первое " + Number1);
}