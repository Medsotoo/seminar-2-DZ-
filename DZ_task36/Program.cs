
int[] list(int leni)
{
    int [] lst = new int [leni];
    for(int i = 0; i < leni; i++)
    {
        lst[i] = new Random().Next(0,100);
    }
    return lst;
}

Console.WriteLine("введите длину массива ");
int len = Convert.ToInt32(Console.ReadLine());

int[] array = list(len);
Console.WriteLine(string.Join(" ",array));


int result = 0;
for(int i = 1; i < array.Length; i += 2)
{
    result += array[i];
}
Console.WriteLine(result);




