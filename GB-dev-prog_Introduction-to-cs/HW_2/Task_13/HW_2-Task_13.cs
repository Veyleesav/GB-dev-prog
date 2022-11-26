//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Enter number:");
int inpNum = Convert.ToInt32(Console.ReadLine());

if (inpNum<100)
{
    Console.WriteLine("There is no third number");
}
else
{
    int res = inpNum;
    while (res/1000>0)
    {
        res = res / 10;
    }
    int ans = res%10;

    Console.WriteLine($"{ans}");
}