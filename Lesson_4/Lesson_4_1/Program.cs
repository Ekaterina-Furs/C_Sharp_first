// // 1. Напишите программу, которая принимает
//    на вход число и выдаёт количество цифр в числе.

int numCount(int num)
{
    int count = 0;
    for(int i = 1; num > 0; i++)
    {
        num /= 10;
        count = i;
    }
    return count;
}

Console.WriteLine("Enter a number: ");
int a = int.Parse(Console.ReadLine()!);
int result = numCount(a);
Console.WriteLine(result);



