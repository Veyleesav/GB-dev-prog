/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/*
k1 * x + b1 = k2 * x + b2
(k1 - k2) * x = b2 - b1
x = (b2 - b1) / (k1 - k2)
y = k1 * x + b1
*/

Console.WriteLine("Enter b1");
decimal b1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Enter k1");
decimal k1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Enter b2");
decimal b2 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Enter k2:");
decimal k2 = Convert.ToDecimal(Console.ReadLine());

decimal x = (b2 - b1) / (k1 - k2);
decimal y = k1 * x + b1;

Console.WriteLine($"({x};{y})");
