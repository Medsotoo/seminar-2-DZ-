Console.WriteLine("введите длину массива ");
int len = Convert.ToInt32(Console.ReadLine());
int[] list(int leni)
{
    int [] lst = new int [leni];
    for(int i = 0; i < leni; i++)
    {
        lst[i] = new Random().Next(100,1000);
    }
    return lst;
}

int[] lst = list(len);
 Console.WriteLine(string.Join(" ",lst));
 int count = 0;

 for(int i = 0; i < lst.Length; i++)
 {
    if (lst[i] % 2 == 0) {count += 1;}
 }

 Console.WriteLine(count);


