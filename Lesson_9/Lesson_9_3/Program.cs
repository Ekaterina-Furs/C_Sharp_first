// 4. Напишите программу, которая на вход принимает два числа A и B,
//    и возводит число А в целую степень B с помощью рекурсии. 


// Для примера взяли отрицательную степень.

double RecPower(int a, int b)
{
    if (b > 0) return a * RecPower(a, b - 1);
    if (b < 0) return RecPower(a, b + 1) * 1 / a;
    else return 1;
}
Console.WriteLine(RecPower(2, -3));