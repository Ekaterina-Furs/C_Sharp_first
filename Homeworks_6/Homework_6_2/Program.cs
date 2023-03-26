//Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Enter k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter k2: ");
int k2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter b2: ");
int b2 = int.Parse(Console.ReadLine()!);
 

int x = -(b1 - b2) / (k1 - k2);
int y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 

Console.WriteLine($"Пересечение в точке: ({x};{y})");

