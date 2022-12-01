double k1 = Convert.ToInt32(Console.ReadLine());
double b1 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double x = 0;
double y = 0;

if(k1 == k2 & b1 == b2){Console.WriteLine("Прямые совпадают");}
else if(k1 == k2 & b1 != b2){Console.WriteLine("Прямые параллельны");}
else
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
}
Console.WriteLine($"({x};{y})");