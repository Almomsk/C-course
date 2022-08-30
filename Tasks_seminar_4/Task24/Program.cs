//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.​
// 7 -> 28​
// 4 -> 10​
// 8 -> 36

int GetNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine("Введите число A: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"{GetNums(num)}");
