Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine("Результат = {0}", sqr);
Console.WriteLine($"Результат = {sqr}");

Console.WriteLine($"Результат = {Math.Pow(number, 2)}");