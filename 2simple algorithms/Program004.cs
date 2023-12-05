//Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
//568 ->  5,6,8; 9 -> 9; 7242 -> 7,2,4,2

Console.Clear();

Console.Write("Enter your number - ");
string strNum = Console.ReadLine();
int.TryParse(strNum, out int Num);

int count = strNum.Length;
int[] Array = new int[count];

for (int i = count - 1; i >= 0; i--)
{
    Array[i] = Num % 10;
    Num /= 10;
}
Console.WriteLine(string.Join(", ", Array));   
