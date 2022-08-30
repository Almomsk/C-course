// Задача 27: Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11​
// 82 -> 10​
// 9012 -> 12

int Function()
{
    int number;
    while (true)
    {
        Console.Write($"Введите число: ");
        string str = Console.ReadLine();

        try
        {
            number = Convert.ToInt32(str);
            return number;
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка, введите другое число");
        }
    }
}

void required_amount(int x)
{
    int sum = 0;
    string str = Math.Abs(x).ToString();
    for (int i = 0; i < str.Length; i++)
    {
        char c = str[i];
        sum += c - '0';
    }

    Console.WriteLine($"{x} -> {sum}");

}

int number = Function();
required_amount(number);