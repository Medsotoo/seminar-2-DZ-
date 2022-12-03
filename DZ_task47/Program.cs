
Console.Write("введите количество сторк в массиве :");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов в массиве :");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double[m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(-10,10) + Math.Round(new Random().NextDouble(),2);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}

