// 2. Напишите программу, которая будет
//    преобразовывать десятичное число в двоичное.

string binary(int num)
{
    string result = "";
    while (num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
}

Console.Write("enter a number:");
int x = int.Parse(Console.ReadLine()!);
string answer = binary(x);
Console.WriteLine(answer);
