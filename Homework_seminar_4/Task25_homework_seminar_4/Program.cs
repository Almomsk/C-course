// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Реализовать функцию возведения в степень самостоятельно!
// Пример​
// 3, 5 -> 243 (3⁵)​
// 2, 4 -> 16​


int Function(string x)
{
    int number;
    while (true)
    {
        Console.Write($"Введите число {x}: ");
        string str = Console.ReadLine();

        try
        {
            number = Convert.ToInt32(str);
            return number;
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка, введите другое число ");
        }
    }
}

int A = Function("A");
int B = Function("B");
int sum = 1;
Console.WriteLine($"Проверка = {Math.Pow(A, B)}");

for (int i = 0; i < B; i++)
{
    sum = sum * A;
}
Console.WriteLine($"{A}, {B} -> {sum}");