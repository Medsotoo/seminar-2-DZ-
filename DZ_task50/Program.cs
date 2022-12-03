Console.Write("введите количество сторк в массиве :");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов в массиве :");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("укажите позицию элемента :");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

bool flag = false;
int result = 0;

int [,] matrix = new int[m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(-10,10);
         Console.Write(matrix[i,j] + " ");
        if(i == x & j == y){flag = true;result = matrix[i,j];}
    } 
    Console.WriteLine();
}
if(flag){Console.Write(result);}
else{Console.Write(" Такого элемента нет в матрице ");}