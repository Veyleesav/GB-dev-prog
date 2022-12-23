/*
Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
    int[,] arr  = new int[2,2];

    for (int i = 0; i < arr.GetLength(0);i++)
    {
        for (int j = 0; j < arr.GetLength(1);j++)
        {
            arr[i,j] = new Random().Next(0,100);
        }
    }
    
    return PrintArr(arr);
}

void MultiplyArrs(int[,] arr, int[,] arr_2, int[,] finalArr)
{
  for (int i = 0; i < finalArr.GetLength(0); i++)
  {
    for (int j = 0; j < finalArr.GetLength(1); j++)
    {
      int element = 0;
      for (int k = 0; k < arr.GetLength(1); k++)
      {
        element += arr[i,k] * arr_2[k,j];
      }
      finalArr[i,j] = element;
    }
  }
  PrintArr(finalArr);
}

Console.WriteLine("First array:");
int[,] firstArr = GetArray();

Console.WriteLine("Second array:");
int[,] secondArr = GetArray();

int[,] finalArr = new int[firstArr.GetLength(0),secondArr.GetLength(1)];

Console.WriteLine();

Console.WriteLine("Multiplied array:");
MultiplyArrs(firstArr,secondArr,finalArr);