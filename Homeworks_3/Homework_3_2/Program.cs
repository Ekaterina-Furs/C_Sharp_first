// 3. Напишите программу, которая принимает на вход число (N) 
//    и выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Ввeдите число: ");
int N = int.Parse(Console.ReadLine()!);

void Cube(int c)
{
    int num = 1;
    while (num <= c)
    {
        Console.WriteLine(num * num * num);
        num ++;
    }
}

Cube(N);