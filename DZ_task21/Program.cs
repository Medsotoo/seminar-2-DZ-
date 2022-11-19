Console.WriteLine("введите координаты первой точки");
int x1 = Convert.ToInt32(Console.ReadLine()), y1 = Convert.ToInt32(Console.ReadLine()),z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine()), y2 = Convert.ToInt32(Console.ReadLine()),z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("расстояние между ними ");
Console.WriteLine(Math.Sqrt((Math.Pow(x2 - x1,2)) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2)));
