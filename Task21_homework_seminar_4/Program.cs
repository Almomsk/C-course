// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84​
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Ведите координаты точки А: ");
Console.Write("Первая точка = ");
int x1= int.Parse(Console.ReadLine()); 
Console.Write("Вторая точка = ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Третья точка = ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ведите координаты точки B: ");
Console.Write("Первая точка = ");
int x2 = int.Parse(Console.ReadLine()); 
Console.Write("Вторая точка = ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Третья точка = ");
int z2 = int.Parse(Console.ReadLine());

int sqr1 = (x1 - x2 - z2) * (x1 - x2 - z2);
int sqr2 = (y1 - y2 - y2) * (y1 - y2 - y2);
int sqr3 = (z1 - z2 - z2) * (z1 - z2 - z2);

int sum = sqr1 + sqr2 + sqr3;

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между точками в 3D пространстве равно: {result}");

//double result = Math.Sqrt(Math.Pow((x1 - x2), 2)
//              + Math.Pow((y1 - y2), 2)
//              + Math.Pow((z1 - z2), 2));
//
// Console.WriteLine($"Расстояние между точками A и B = {result:F}");