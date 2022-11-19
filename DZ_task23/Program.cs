Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i < num + 1; i++)
{
    Console.WriteLine(Math.Pow(i,3));
}