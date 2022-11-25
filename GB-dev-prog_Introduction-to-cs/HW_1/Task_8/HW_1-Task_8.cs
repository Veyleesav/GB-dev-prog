// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Enter number:");
int a = Convert.ToInt32(Console.ReadLine());

var list = new List<int>();

foreach (int i in Enumerable.Range(1, a)) //Попытка прийти к понятным тезисам питона в стиле математиков, чтобы свести задачу к известной
{
    if (i%2==0)
    {
    list.Add(i);
    }
}
var listArr = list.ToArray();
string res = string.Join( ",", listArr);
Console.WriteLine($"Enter number: {res}");