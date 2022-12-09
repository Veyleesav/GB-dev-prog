// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Вроде на семинаре говорили, что можно задать массив случайно, поэтому сделал так

int[] RandomArr()
{
    int[] arr = new int[8];
    int i=0;    
    while (i<arr.Length)
    {
        arr[i]=new Random().Next(0,99);
        i++;
    }
    return arr;
}

int[] result = RandomArr(); //generate random array

 Console.WriteLine("[{0}]", string.Join(", ", result));