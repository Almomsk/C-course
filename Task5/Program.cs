Console.WriteLine("Add number: ");
int num = int.Parse(Console.ReadLine());
int current = -num;
Console.WriteLine(current);
while(current <= num)
{
    Console.Write($"{current} ");
    current++;
}