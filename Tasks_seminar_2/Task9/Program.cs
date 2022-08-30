// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int num = new Random().Next(10, 100); // [a, b]

int a1 = num % 10;
int a2 = num / 10;

int max = a1;

if (max < a2)
{
    max = a2;
}

Console.WriteLine($"{num}, max: {max}");
