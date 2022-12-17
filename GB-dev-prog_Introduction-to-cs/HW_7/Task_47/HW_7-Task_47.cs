/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

//Setting array size
Console.WriteLine("Enter m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n:");
int n = Convert.ToInt32(Console.ReadLine());

//setting random var
var rand = new Random();

decimal[,] arr  = new decimal[m,n];

for (int i = 0; i < arr.GetLength(0);i++)
{
    for (int j = 0; j < arr.GetLength(1);j++)
    {
        arr[i,j] = new decimal(rand.NextDouble()*100);
    }
}

//Will need to show array in next tasks so we build a function for it

void WriteArray(decimal[,] arr)
{
    for (int i = 0; i < arr.GetLength(0);i++)
    {
        for (int j = 0; j < arr.GetLength(1);j++)
        {
            Console.Write($"{Math.Round(arr[i,j],1)} ");
        }
        Console.WriteLine();
    }
}

WriteArray(arr);