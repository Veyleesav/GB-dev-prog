/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] spiral = new int[4, 4];

int tmp = 1;
int x = 0;
int y = 0;

void PrintArr (int[,] arr)
{
  for (int x = 0; x < arr.GetLength(0); x++)
  {
    for (int y = 0; y < arr.GetLength(1); y++)
    {
      if (arr[x,y] < 10)
      Console.Write($"0{arr[x,y]} ");

      else Console.Write($"{arr[x,y]} ");
    }
    Console.WriteLine();
  }
}

while (tmp <= spiral.GetLength(0) * spiral.GetLength(1))
{
  spiral[x, y] = tmp;
  tmp++;
  if ((x < y) && ((x + y) >= (spiral.GetLength(0) - 1)))
    x++;
  else if ((x <= y + 1) && ((x + y) < (spiral.GetLength(1) - 1)))
    y++;
  else if ((x >= y) && ((x + y) > (spiral.GetLength(1) - 1)))
    y--;
  else
    x--;
}

PrintArr(spiral);