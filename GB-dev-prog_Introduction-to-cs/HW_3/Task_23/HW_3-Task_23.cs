//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Enter N:");
int n = Convert.ToInt32(Console.ReadLine());

string[] results = new String [n];

foreach (int element in Enumerable.Range(1, n))
{
    results[element-1] = (Convert.ToString(Math.Pow(element,3)));
}
string output = string.Join(", ",results);
Console.WriteLine($"{output}");