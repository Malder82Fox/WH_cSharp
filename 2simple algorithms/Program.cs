//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
//Если обе координаты (x и y) положительны - 1 четверть.
//Если координата x отрицательна, а координата y положительна - 2 четверть.
//Если обе координаты отрицательны - 3 четверть.
//Если координата x положительна, а координата y отрицательна - 4 четверть.

Console.Clear();

Console.Write("Enter first number - ");
string strFirstNum = Console.ReadLine();
int.TryParse(strFirstNum, out int FirstNum);
Console.Write("Enter second number - ");
string strSecondNum = Console.ReadLine();
int.TryParse(strSecondNum, out int SecondNum);

if (FirstNum == 0 || SecondNum == 0)
{
    Console.WriteLine($"`{strFirstNum}` or `{strSecondNum}` must not be zero");
    return;
}

else if (FirstNum > 0 && SecondNum > 0)
{
    Console.WriteLine("Your point is at 1 quarter");
}

else if (FirstNum < 0 && SecondNum > 0)
{
    Console.WriteLine("Your point is at 2 quarter");
}

else if (FirstNum < 0 && SecondNum < 0)
{
    Console.WriteLine("Your point is at 3 quarter");
}

else if (FirstNum > 0 && SecondNum < 0)
{
    Console.WriteLine("Your point is at 4 quarter");
}
