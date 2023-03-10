int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);

void divide(int nm1, int nm2)
{
    if (nm1 % nm2 == 0)
    {
        Console.WriteLine($"Число {nm2} кратно {nm1}");
    }
    else
    {
        Console.WriteLine($"Число {nm2} не кратно {nm1}");
        Console.WriteLine(nm1 % nm2);
    }
} 
divide(num1, num2);
