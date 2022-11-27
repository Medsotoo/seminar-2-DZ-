double[] list(int leni)
{
    double[] lst = new double [leni];
    for(int i = 0; i < leni; i++)
    {
        lst[i] = new Random().Next(1,100) + Math.Round(new Random().NextDouble(),2);
    }
    return lst;
}

Console.WriteLine("введите длину массива ");
int len = Convert.ToInt32(Console.ReadLine());

double[] array = list(len);
double min = array[0];
double max = array[0];

Console.WriteLine(string.Join(" ",array));

for(int i = 0;i < array.Length; i++)
{
    if (array[i] < min){min = array[i];}
    else if(array[i] > max){max = array[i];}
}

Console.WriteLine(Math.Round(max - min,2));
