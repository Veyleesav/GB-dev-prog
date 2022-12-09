// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumNum(int inpNum)
{
    int counter = Convert.ToString(inpNum).Length;
    int shift = 0;
    int result = 0;
    int i = 0;
    while (i < counter)
    {
      shift = inpNum - inpNum % 10;
      result = result + (inpNum - shift);
      inpNum = inpNum / 10;
      i++;
    }
   return result;
 }


Console.Write("Enter a number:");
int inpNum = Convert.ToInt32(Console.ReadLine());

int result = SumNum(inpNum);
Console.WriteLine($"{result}");
