﻿/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
    int[,] arr  = new int[3,4];

    for (int i = 0; i < arr.GetLength(0);i++)
    {
        for (int j = 0; j < arr.GetLength(1);j++)
        {
            arr[i,j] = new Random().Next(0,100);
        }
    }
    
    return PrintArr(arr);
}

void OrderArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) 
    { 
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++) //one more loop to cycle inside row
            {
                int tmp = arr[i, k + 1];
                if (arr[i, k] < arr[i, k + 1])
                {
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = tmp;
                }
            }
        }
    }
    //to print array
    PrintArr(arr);
}

Console.WriteLine("Initial array:");
int[,] arr = GetArray();
Console.WriteLine("Ordered array:");
OrderArr(arr);