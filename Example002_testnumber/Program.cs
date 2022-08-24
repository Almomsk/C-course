Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
double sqr_b = Math.Pow (b, 2);
if (a == sqr_b)
{
Console.WriteLine("Yes");
}
else
{
Console.WriteLine("No");
} 