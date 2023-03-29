//Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Enter k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Enter b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Enter k2: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.Write("Enter b2: ");
double b2 = double.Parse(Console.ReadLine()!);

void InterSec(double k_1, double k_2, double b_1, double b_2)
{
    double k_sub = k_1 - k_2;
    if (k_sub != 0)
    {
        double x = (b_2 - b_1) / (k_1 - k_2);
        double y = k_1 * x + b_1;
        Console.WriteLine($"The point of intersection: ({x},{y})");
    }
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine("The infinitive number of intersection points");
    else
        Console.WriteLine("There is no intersection point");
    
}

InterSec(k1, k2, b1, b2);