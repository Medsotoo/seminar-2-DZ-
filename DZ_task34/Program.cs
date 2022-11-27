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


 Console.WriteLine(string.Join(" ",list(len)));
 int count = 0;

 for(int i = 0; i < list(len).Length; i++)
 {
    if (list(len)[i] % 2 == 0) {count += 1;}
 }

 Console.WriteLine(count);


