/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


void PrintArr (int[,,] arr)//In order to get output as in task we reorder axes
{
  for (int z = 0; z < arr.GetLength(0); z++)
  {
    for (int x = 0; x < arr.GetLength(1); x++)
    {
      for (int y = 0; y < arr.GetLength(2); y++)
      {
        Console.Write($"{arr[x,y,z]}({x},{y},{z}) ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

int[,,] arr = new int[2, 2, 2] //Не понял, предполагалась ли случайная генерация, поэтому просто сформировал
{
    {{66,27},{25,90}},
    {{34,26},{41,55}}
};

PrintArr(arr);
