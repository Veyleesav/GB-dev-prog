// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


Console.WriteLine("Task 17");
Console.WriteLine("Enter x:");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y:");
int yCoord = Convert.ToInt32(Console.ReadLine());

if (xCoord>0 && yCoord>0)
{
    Console.WriteLine("First quarter");
}
else if (xCoord<0 && yCoord>0)
{
    Console.WriteLine("Second quarter");
}
else if (xCoord<0 && yCoord<0)
{
    Console.WriteLine("Third quarter");
}
else
{
    Console.WriteLine("Fourth quarter");
}

// Задача №18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
Console.WriteLine(" ");
Console.WriteLine("Task 18");
Console.WriteLine("Enter quarter number:");
int quarter = Convert.ToInt32(Console.ReadLine());

switch (quarter)
{
    case 1: Console.WriteLine("x=(0;+∞); y=(0;+∞)");
    break;
    case 2: Console.WriteLine("x=(-∞;0;); y=(0;+∞)");
    break; 
    case 3: Console.WriteLine("x=(-∞;0;); y=(-∞;0;)");
    break;
    case 4: Console.WriteLine("x=(0;+∞); y=(-∞;0;)");
    break;
    default: Console.WriteLine("Smth went wrong...");
    break;
}



// 21) Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
Console.WriteLine(" ");
Console.WriteLine("Task 21");
Console.WriteLine("Point A:");
Console.WriteLine("Enter x:");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y:");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Point B:");
Console.WriteLine("Enter x:");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y:");
int yb = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt( Math.Pow((xb-xa),2) + Math.Pow((yb-ya),2) );

Console.WriteLine($"Distance between A & B: {distance:f2}");


// 22) Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
Console.WriteLine(" ");
Console.WriteLine("Task 22");

Console.WriteLine("Enter N:");
int n = Convert.ToInt32(Console.ReadLine());

//Thats array seminar after all
string[] results = new String [n];

foreach (int element in Enumerable.Range(1, n))
{
    results[element-1] = (Convert.ToString(Math.Pow(element,2)));
}
string output = string.Join(", ",results);
Console.WriteLine($"{output}");