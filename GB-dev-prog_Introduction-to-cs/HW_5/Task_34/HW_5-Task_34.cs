// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int RandomEven()
{
    int[] arr = new int[new Random().Next(1,10)];
    int i=0;
    int counter = 0;    
    while (i<arr.Length)
    {
        arr[i]=new Random().Next(100,999);
        i++;
    }
    foreach (int j in arr)
    {
        if (j % 2 == 0)
        {
            counter++;
        }
    }
    Console.WriteLine("[{0}]", string.Join(", ", arr)); //Оставил для наглядности
    return counter;
}

int result = RandomEven(); //generate random array and count even numbers in it

Console.WriteLine($"{result}");