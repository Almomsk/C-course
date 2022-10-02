// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

int NumAkkerman(int a, int b)
{
  if (a == 0)
    return b + 1;
  else
    if ((a > 0) && (b == 0))
      return NumAkkerman(a - 1, 1);
    else
      return NumAkkerman(a - 1, NumAkkerman(a, b - 1));
}

Console.WriteLine("Введите неотрицательное число m: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите неотрицательное число n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(NumAkkerman(m, n));
