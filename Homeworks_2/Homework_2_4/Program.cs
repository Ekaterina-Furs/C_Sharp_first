// Напишите программу, которая принимает на вход цифру, и проверяет, является ли этот день выходным. 
//Если число не день недели, то выводит, что такого дня нет.

Console.WriteLine("Enter the day of the week");
int a = int.Parse(Console.ReadLine()!);

void Week(int day)
{
    if (day >= 1 && day <= 5)
    {
        Console.WriteLine("No, this is not a weekend");
    }
    else if (day >= 6 && day <= 7)
    {
        Console.WriteLine("Yes, this is weekend!");
    }
    else
    {
        Console.WriteLine("Not a day of a week");
    }
}

Week(a);
