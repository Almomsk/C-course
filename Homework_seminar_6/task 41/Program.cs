// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//Функция проверки на число
bool CheckingForNumber(string str)
{
    int num;
    return int.TryParse(str, out num);
}

//Фукция вывода сообщений и получения числа
int GetData(string message)
{
    while (true)
    {
        Console.Write(message);
        string number = Console.ReadLine();
        if (CheckingForNumber(number))
        {
            return int.Parse(number);
            break;
        }
        else
        {
            Console.WriteLine("Введено не число. Попробуйте ещё раз.");
            Console.WriteLine();
        }
    }
}

//Функция вывода массива и подсчёта сколько чисел больше 0
void HowManyNumbers(int num)
{
    int count = 0;
    int[] temp = new int[num];
    for (int i = 1; i <= num; i++)
    {
        int number = GetData($"Введите {i} число: ");
        temp[i - 1] = number;
        if (number > 0)
        {
            count++;
        }
    }
    Console.WriteLine($" {string.Join(", ", temp)} -> {count}");
}

string messag = "Сколько чисел будете проверять. Введите число: ";
HowManyNumbers(GetData(messag));
