// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти 1-4: ");
int num = int.Parse(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("x > 0 и y > 0");
}
else
if (num == 2)
{
    Console.WriteLine("x < 0 и y > 0");
}
else
if (num == 3)
{
    Console.WriteLine("x < 0 и y < 0");
}
else 
if (num == 4)
{
 Console.WriteLine("x > 0 и y < 0");
 }
else{
Console.WriteLine("Введите правильную четверть");
}