// Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.

int SumNum(int num)
{
    int all_sum = 0;

    for(int i = 0; i <= num; i++)
        all_sum += i;
        // all_sum = all_sum + i;
    
    return all_sum;
}

int val = int.Parse(Console.ReadLine()!);
int result = SumNum(val);
Console.WriteLine(result);