// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.​
// 4 -> 24 ​
// 5 -> 120

int xNumber(int num)
{
    int result = 1;
    for(int i=1; i <= num; i++)
    {
        result = result * i;
        }
        return result;
}
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{xNumber(number)}");