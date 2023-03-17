// 2. Напишите программу, которая принимает на вход
//    число N и выдаёт произведение чисел от 1 до N.

int ymn(int a)
{
    int x = 1;
    for (int i = 1; i<=a; i++)
    {
        x *= i;
    }
    return x;

}
Console.WriteLine("Напишите любое число");
int P = ymn(int.Parse(Console.ReadLine()!));
Console.WriteLine(P);
