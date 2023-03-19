// Напишите цикл, который принимает на вход числа A и B и возводит число A в натуральную степень B.

Console.WriteLine("Enter number A");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number B");
int B = int.Parse(Console.ReadLine()!);



int Degree(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res = res * a;
    }
    return res;
}
Degree(A,B);
int result = Degree(A, B);
Console.WriteLine($"The result is {result}");

