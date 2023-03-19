// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

Console.WriteLine("Enter number  ");
int number = int.Parse(Console.ReadLine()!);

int sum = 0;
while(number > 0)
{
    int digit = number % 10;
    number = number / 10;
    sum = sum + digit;
}

Console.WriteLine($"The sum of the digits is {sum}");