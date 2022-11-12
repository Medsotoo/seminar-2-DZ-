Console.WriteLine("введите первое число");
int digit1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int digit2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int digit3 = Convert.ToInt32(Console.ReadLine());

if (digit1 > digit2  ||  digit1 > digit3)
{
    Console.WriteLine($"max = {digit1}");
}
else if(digit2 > digit1  || digit2 > digit3)
{
    Console.WriteLine($"max = {digit2}");
}
else 
{
    Console.WriteLine($"max = {digit3}");
}
