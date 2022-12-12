
int[,] SortMatrix(int[,] mat)
{   
    for(int i = 0; i < mat.GetLength(0); i++)
    {
        for(int j = 0; j < (mat.GetLength(1)); j++)
        {
            for(int b = 0;b < mat.GetLength(1); b++)
            {
                if(mat[i, b] > mat[i, j])
                {
                    int temp = mat[i,j];
                    mat[i,j] = mat[i,b];
                    mat[i,b] = temp;
                }
            }
        }
    }
    return mat;
}

int[,] NewArray(int m,int n)
{
    int [,] matrix = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrix[i,j] = new Random().Next(0,10);
        }
    }
    return matrix;
}

void Printmatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Printmatrix(SortMatrix(NewArray(3,4)));

