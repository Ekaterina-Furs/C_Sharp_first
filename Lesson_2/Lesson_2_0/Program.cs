int TakeNum (int num)
{
    Console.WriteLine(num);
    return num % 10;
}

int th_num = new Random().Next(100, 1000);
TakeNum(th_num);
int result = TakeNum(th_num);
Console.WriteLine(result);