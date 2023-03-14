// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Enter the number");
int a = int.Parse(Console.ReadLine()!);

int ThirdNumber(int num)
{
    while (num > 999)
        {
            num = num / 10;
        }
    return num % 10;
}
if(a < 100)
{
    Console.WriteLine("The third number doesn't exist");
}
else
{
    if(a >= 100)
    ThirdNumber(a);
    int result = ThirdNumber(a);
    Console.WriteLine(result);
}





