/*
Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

static int[,] PrintArr(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0);i++)
    {
        for (int j = 0; j < arr.GetLength(1);j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}

//generating random array for test
static int[,] GetArray()
{
    int[,] arr  = new int[4,4];

    for (int i = 0; i < arr.GetLength(0);i++)
    {
        for (int j = 0; j < arr.GetLength(1);j++)
        {
            arr[i,j] = new Random().Next(0,100);
        }
    }
    
    return PrintArr(arr);
}

void GetSmallestRowSum(int[,] arr)
{   int smallestRow = 0;
    int smallestSum = Int32.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++) //Columns
    {   int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++) //Rows
        {
            sum+=arr[i,j];
        }
        if (sum<smallestSum)
        {
            smallestRow=i+1;
            smallestSum=sum;
        }
    }
    Console.WriteLine($"The smallest sum is in row #{smallestRow}");
}

Console.WriteLine("Initial array:");
int[,] arr = GetArray();
Console.WriteLine();
GetSmallestRowSum(arr);