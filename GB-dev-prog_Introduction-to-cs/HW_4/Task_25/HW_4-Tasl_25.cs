// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Enter A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter B:");
int b = Convert.ToInt32(Console.ReadLine());
int result = a;

while (b>1)
{
    result=result*a;
    b--;
}

Console.WriteLine($"{result}");
