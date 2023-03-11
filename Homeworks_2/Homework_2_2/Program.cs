// Напишите программу, которая выводит слуайное трехзначное число и удаляет вторую цифру этого числа

int a = new Random().Next(100, 1000);
int TakeNum(int num)
{
    Console.WriteLine(num);
    int num1 = num / 100;
    int num2 = num % 10;
    int num3 = num1*10 + num2;
    return num3;
}
TakeNum(a);
int result = TakeNum(a);
Console.WriteLine(result);

