/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

//generating random array for test
static int[,] GetArray(){
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

int[,] arr=GetArray();

void GetElement(int[,] arr)
{
    Console.WriteLine("Enter first index:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second index:");
    int n = Convert.ToInt32(Console.ReadLine());

    try
    {
        Console.WriteLine($"{arr[m,n]}"); //if we need positions and not indexes just use m-1 and n-1
    }
    catch
    {
        Console.WriteLine("There is no such number in the array above");
    }
    
}

GetElement(arr);