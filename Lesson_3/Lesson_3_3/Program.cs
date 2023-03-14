// 3. Напишите программу, которая принимает на вход число (N) 
//    и выдаёт таблицу квадратов чисел от 1 до N.

void S(int n)
{
    int a = 1;
    while (a <= n)
    {
        Console.WriteLine(a * a);
        a++;
    }
}
Console.WriteLine("Ввeдите число: ");
S(int.Parse(Console.ReadLine()!));
