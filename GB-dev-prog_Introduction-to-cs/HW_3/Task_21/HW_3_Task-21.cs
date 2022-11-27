// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Point A:");
Console.WriteLine("Enter x:");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y:");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter z:");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Point B:");
Console.WriteLine("Enter x:");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y:");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter z:");
int zb = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt( Math.Pow((xb-xa),2) + Math.Pow((yb-ya),2) + Math.Pow((zb-za),2) );

Console.WriteLine($"Distance between A & B: {distance:f2}");
