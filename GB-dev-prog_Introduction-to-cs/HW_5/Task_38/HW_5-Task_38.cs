/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Decimal[] arr = new decimal[5];
int i = 0;
 while (i < arr.Length) //генерация рандомного массива с вещественными числами
    {
        var rand = new Random();
        var item = new decimal(rand.NextDouble())*100;
        arr[i]=item;
        i++;
    }
Console.WriteLine("[{0}]", string.Join(", ", arr)); //Оставил для наглядности
Console.WriteLine($"{arr.Max<decimal>()-arr.Min<decimal>()}");