// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());
int x = number;
int remainder = 0;
int res = 0;
while (x>0)
{
    remainder = x % 10; //Get last digit as a remainder
    res = (res*10)+remainder; //Get previous remainder to next position and add current remainder
    x = x / 10; //To reach next digit
}
if (res==number)
{
    Console.WriteLine("Yes");  
}
else
{
    Console.WriteLine("No");  
}
