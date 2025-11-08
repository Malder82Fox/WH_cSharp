//Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.
//40 ->  4; 96 -> 9; 72 -> 7

Console.Clear();

Console.Write("Enter your number [10-99] - ");
string strNum = Console.ReadLine();
int.TryParse(strNum, out int Num);

if (Num < 10 || Num > 99)
{
    Console.WriteLine("It is not correct !!! `10-99`");
}

else
{
    int[] Array = new int[2];
    for (int i = 1; i >= 0; i--)
    {
        Array[i] = Num % 10;
        Num /= 10; // can use "Num = Num / 10"
    }

    int FirstNum = Array[0];
    int SecondNum = Array[1];

    if (FirstNum >= SecondNum)
    {
        Console.WriteLine($"Larger number `{FirstNum}` in digit `{strNum}`");
    }
    else
    {
        Console.WriteLine($"Larger number `{SecondNum}` in digit `{strNum}`");
    }
}

