// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Enter the number");
int a = int.Parse(Console.ReadLine()!);

if(a < 100)
{
    Console.WriteLine("The third number doesn't exist");
}
else
{
    if(a < 999) a = a % 10;
    Console.WriteLine(a);
}

    



