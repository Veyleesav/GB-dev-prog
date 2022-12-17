/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

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

    //to print array

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

void GetAvg(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0);i++)
    {
        double sum=0;
        double divider = 0;
        for (int j = 0; j < arr.GetLength(1);j++)
        {
            sum+=arr[j,i];
            divider++;
        }
        Console.WriteLine($"Average for the columns with index {i} is {sum/divider}");
    }
}

int[,] arr=GetArray();
GetAvg(arr);