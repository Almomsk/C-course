// Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.
// 5 ->

void Elka(int number)
{
  Console.WriteLine($"{number} -> ");
  for (int i = 0; i < number; i++)
  {
    for (int p = number; p > i; p--)
      {
        Console.Write(" ");
      }
    for (int j = 0; j <= i * 2; j++)
    {
      Console.Write("*");
    }
  Console.WriteLine();
  }



}

int Check()
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


int number = Check();
Console.WriteLine();
Elka(number);