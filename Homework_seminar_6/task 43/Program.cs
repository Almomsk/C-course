// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Функция проверки на число
bool CheckingForNumber(string str)
{
    int num;
    return int.TryParse(str, out num);
}

//Фукция вывода сообщений и получения числа
double GetData(string message)
{
    while (true)
    {
        Console.Write(message);
        string number = Console.ReadLine();
        if (CheckingForNumber(number))
        {
            return double.Parse(number);
            break;
        }
        else
        {
            Console.WriteLine("Введено не число. Попробуйте ещё раз.");
            Console.WriteLine();
        }
    }
}
//Функция Найти пересечения
double[] FindIntersections(double b1, double k1, double b2, double k2)
{
    double[] temp = new double[2];
    if (b1 == b2 & k1 == k2) Console.WriteLine("Прямые совпадают");
    else if (k1 == k2) Console.WriteLine("Прямые параллельны друг другу");
    else
    {
        temp[0] = (b2 - b1) / (k1 - k2);
        temp[1] = k1 * temp[0] + b1;
    }
    return temp;
}


double b1 = GetData("Введите b1: ");
double k1 = GetData("Введите k1: ");
double b2 = GetData("Введите b2: ");
double k2 = GetData("Введите b2: ");
double[] arrayXY = FindIntersections(b1, k1, b2, k2);

Console.WriteLine($" b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ( {string.Join("; ", arrayXY)} )");