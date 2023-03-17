//напишите программу, которая принимает на вход пятизначное числои  и проверяет , является ли оно палиндромом.

Console.WriteLine("Enter a five-digit number ");
int a = int.Parse(Console.ReadLine()!);

void Palindrome(int num)
{
    int num1 = num / 10000;
    int num5 = num % 10;
    int num2 = num / 1000 % 10;
    int num4 = num % 100 / 10;

    if(num1 == num5 && num2 == num4)
    {
        Console.WriteLine($"Yes, {num} is a palindrome");
    }
    else
    {
        Console.WriteLine($"No, {num} is not a palindrome");
    }
}
Palindrome(a);
