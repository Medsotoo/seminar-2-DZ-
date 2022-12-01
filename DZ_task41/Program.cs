String[] array = Console.ReadLine().Split(','); 
int count = 0;
for(int i = 0;i < array.Length; i++)
{
    if(Convert.ToInt32(array[i]) > 0){count += 1;}
}
Console.WriteLine(count);
