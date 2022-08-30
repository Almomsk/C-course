// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.​
// 456 -> 3​
// 78 -> 2​
// 89126 -> 5

int colNumber(int num)
{
    int col = 0;
    while (num!= 0)
        {
            col++;
            num = num/10;
        }
    return col;
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{colNumber(number)}");