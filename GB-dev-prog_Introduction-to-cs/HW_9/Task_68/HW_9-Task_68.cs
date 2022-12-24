/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
Console.WriteLine("Enter M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int Ackermann(int m, int n) 
/*С учетом ограничений учебных задач используем int,
//т.к если мы выйдем за ТЗ и применим, например Ackermann(4,4),
то количество цифр в порядке этого числа многократно превзойдет
количество атомов в наблюдаемой части Вселенной. А это много.
*/
{
    if(m == 0)
    {
        return n + 1;
    }
    if(m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.WriteLine($"{Ackermann(m,n)}");
