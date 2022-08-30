// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет ​
// 46 -> нет ​
// 161 -> да

Console.WriteLine("Add new number");
int num1 = int.Parse(Console.ReadLine());

if (num1 % 7 == 0 && num1 % 23 == 0) // && - если одна сторона истина, то вторая часть не проверяется
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
