// Задача 13: Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6​
// 78 -> третьей цифры нет​
// 32679 -> 6

Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
  Console.WriteLine("третья цифра: " + numberText[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
}