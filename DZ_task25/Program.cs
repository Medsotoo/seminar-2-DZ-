Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите степень числа");
int b = Convert.ToInt32(Console.ReadLine());
int res = a;
for(int i = 2; i <= b; i++ )
{
    res *= a;
}
Console.WriteLine(res);
