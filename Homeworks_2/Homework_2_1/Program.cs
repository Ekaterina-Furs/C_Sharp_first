// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

int a = new Random().Next(100, 1000);
int TakeNum(int num)
{
    Console.WriteLine(num);
    int num1 = num / 10;
    int num2 = num1 % 10;
    return num2;
}
TakeNum(a);
int result = TakeNum(a);
Console.WriteLine(result);