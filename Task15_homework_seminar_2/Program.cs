// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да ​
// 7 -> да ​
// 1 -> нет

int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write(a + " - Выходной день");
        }
        else
        {
            Console.Write(a + " - Рабочий день");
        }
    }
    else
    {
        Console.Write("Число не является днем недели");
    }
    return " день.";
}