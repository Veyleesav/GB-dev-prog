/*
Задача: написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

//Initial array
string[] initArr = {"Lorem","ipsum","dolor","sit","amet","consectetur","adipiscing",
"elit","Proin","venenatis","semper","facilisis","Donec","tincidunt","ex","eget",
"sapien","laoreet","pellentesque","Nam","sed","volutpat","mi","Maecenas","pellentesque",
"mi","et","viverra","bibendum","Aliquam","risus","nibh","vulputate","in","varius","malesuada",
"auctor","eu","ante","Maecenas","sit","amet","tincidunt","ex","ultrices","pretium","dolor","Suspendisse",
"quis","auctor","ipsum","Suspendisse","ac","accumsan","mauris","ut","iaculis","mauris","Sed","a","dolor",
"justo","Nunc","et","ante","turpis","Curabitur","tincidunt","tellus","vel","sagittis","tempus","Sed",
"aliquet","tempor","neque","cursus","ultricies","massa","efficitur","a","Vivamus","sagittis","libero",
"quis","ultrices","sollicitudin","Proin","eu","augue","vel","libero","pharetra","pulvinar","nec","id",
"erat","Donec","fringilla","turpis","id","nibh","malesuada","ut","volutpat","orci","tempor"};

void lessThanThree(string[] arr)
{
    int size=0;

    //getting size of final array because we cant use lists in this task
    foreach (string i in arr)
    {
        if (i.Length<=3)
        {
        size++;
        }
    }

    //Generating final filtered array
    string[] finalArr = new string[size];
    int cntr=0;

    foreach (string i in arr)
    {
        if (i.Length<=3)
        {
        finalArr[cntr] = i;
        cntr++;
        }
    }

    Console.Write("[");
    for (int j = 0; j < finalArr.Length; j++)
    {
        if (j<finalArr.Length-1)
        {
            Console.Write($"'{finalArr[j]}'");
            Console.Write(",");
        }
        else
        {
            Console.Write($"'{finalArr[j]}'");
        }
    }
    Console.Write("]"); 
}

lessThanThree(initArr);