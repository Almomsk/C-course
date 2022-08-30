// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.​
// 34, 5 -> не кратно, остаток 4 ​
// 16, 4 -> кратно

Console.WriteLine("Add first number: ");
int a1 = int.Parse(Console.ReadLine());

Console.WriteLine("Add second number: ");
int a2 = int.Parse(Console.ReadLine());

int a3 = a1 % a2;

if(a3 == 0)
{
    Console.WriteLine("divisible");
}
else
{
    Console.WriteLine($"not divisible. End The remainder is equal to = {a3}");
}