/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Enter numbers:");
string[] arr = Console.ReadLine().Split(new string[] { ","," " ," ,"," , ","; ",";","; "," ; "}, StringSplitOptions.RemoveEmptyEntries);

int counter = 0;
foreach (string i in arr)
{
    if (Convert.ToInt32(i)>0)
    {
        counter++;
    }
}

Console.WriteLine($"{counter}");