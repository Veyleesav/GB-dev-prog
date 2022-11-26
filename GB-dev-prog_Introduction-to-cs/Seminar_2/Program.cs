// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Console.WriteLine("Task N");

Random rnd = new Random();
int rndInt = rnd.Next(10,99);
string intStr = Convert.ToString(rndInt);
Console.WriteLine($"Generated number {intStr}");

if (intStr[0]>intStr[1])
{
    Console.WriteLine($"{intStr[0]};");
}
else
{
    Console.WriteLine($"{intStr[1]};");
}


// 8) Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98


Console.WriteLine("Task 8");
int rndBig = rnd.Next(100,1000);
string bigStr = Convert.ToString(rndBig);
Console.WriteLine($"Generated number {rndBig}");

Console.WriteLine($"{bigStr[0]+""+(bigStr[2])};");


//12)
//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

Console.WriteLine("Task 12");
Console.WriteLine("Enter numbers in one line:");
string[] inpStr = Console.ReadLine().Split(new string[] { ","," " ," ,"," , ","; ",";","; "," ; "}, StringSplitOptions.RemoveEmptyEntries);
int firstNum=Convert.ToInt32(inpStr[0]);
int secondNum=Convert.ToInt32(inpStr[1]);

if (firstNum%secondNum==0)
{
    Console.WriteLine("Is a multiple");
}
else
{
    Console.WriteLine($"not a multiple, the remainder is {firstNum%secondNum} ");
}

//14) Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
//7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

Console.WriteLine("Task 14");
Console.WriteLine("Enter numbers in one line:");

int inpNum = Convert.ToInt32(Console.ReadLine());
if (inpNum%7==0 && inpNum%23==0)
{
    Console.WriteLine("Yes"); 
}
else
{
    Console.WriteLine("No"); 
}

//16) Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет

Console.WriteLine("Task 16");
Console.WriteLine("Enter numbers in one line:");
string[] inpStr_new = Console.ReadLine().Split(new string[] { ","," " ," ,"," , ","; ",";","; "," ; "}, StringSplitOptions.RemoveEmptyEntries);
int firstNum_new=Convert.ToInt32(inpStr_new[0]);
int secondNum_new=Convert.ToInt32(inpStr_new[1]);

if (Math.Pow(firstNum_new,2)==secondNum_new)
{
Console.WriteLine("Yes");
}
else if (Math.Pow(secondNum_new,2)==firstNum_new)
{
Console.WriteLine("Yes");
}
else{
Console.WriteLine("No");
}