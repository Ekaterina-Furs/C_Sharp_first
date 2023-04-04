// 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию. взяли 445 

Console.Write("Enter number N: ");
int num = int.Parse(Console.ReadLine()!);

int RecSum(int n)
{
    if (n == 0) return 0;
    return n % 10 + RecSum(n / 10);
}

Console.Write($"The sum of digits is {RecSum(num)}");
