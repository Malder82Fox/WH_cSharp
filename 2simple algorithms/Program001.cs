//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. (ответ 161)

Console.Clear();

Console.Write("Enter your number - ");
string strNum = Console.ReadLine();
int.TryParse(strNum, out int Num);

int FirstCheck = Num % 7;
int SecondCheck = Num % 23;

if (FirstCheck == 0 && SecondCheck == 0)
{
    Console.WriteLine($"YES, Your number `{strNum}` is a multiple of both 7 and 23");
}
else
{
    Console.WriteLine($"NO, Your number `{strNum}` is not a multiple of both 7 and 23");
}