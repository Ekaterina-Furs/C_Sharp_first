Console.WriteLine("Enter the number N");
int N = int.Parse(Console.ReadLine()!);
int a = 1;

while (a <= N)
{
    if(a%2 == 0)
    {
        Console.Write(a + " ");
    }
    a++;   
}