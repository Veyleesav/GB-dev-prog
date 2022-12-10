/* 
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int RandomOddSum()
{
    int[] arr = new int[new Random().Next(2,10)];
    int i = 0;
    int oddSum = 0;    
    while (i < arr.Length)
    {
        arr[i]=new Random().Next(100,999);
        i++;
    }
    int j = 0;
    while (j < arr.Length)
    {
        if (j % 2 == 0) //Есть расхождение в ТЗ, решил сделать так, чтобы совпадало с примером вывода. Для соответствия с текстом  нужно в условии заменить != на ==
        {
            oddSum += arr[j];
        }
        j++;
    }
    Console.WriteLine("[{0}]", string.Join(", ", arr)); //Оставил для наглядности
    return oddSum;
}

int result = RandomOddSum(); //generate random array and count even numbers in it

Console.WriteLine($"{result}");