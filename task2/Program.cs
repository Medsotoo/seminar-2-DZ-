Console.WriteLine("введите первое число");
int digit1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int digit2 = Convert.ToInt32(Console.ReadLine());

if (digit1 > digit2)
{
    Console.WriteLine($"max = {digit1}");
}
else
{
    Console.WriteLine($"max = {digit2}");
}