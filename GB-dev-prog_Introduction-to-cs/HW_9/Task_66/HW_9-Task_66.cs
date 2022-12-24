/* 
Задача 66: Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Enter M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int sum = m;
int GetNum(int m, int n)
{
    if (m < n)
    {
        sum += (m+1);
        m++;
        GetNum(m,n);
    }
    return sum;
}

Console.WriteLine($"{GetNum(m,n)}");