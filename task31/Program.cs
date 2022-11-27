Console.WriteLine("введите длинну массива");
int count = Convert.ToInt32(Console.ReadLine());


int [] array = new int [count];

for (int i = 0; i < count; i++)
{
    array[i] = new Random().Next(-9,10);
    Console.Write(" " + array[i]);
}



for(int i = 0; i < count; i++)
{
    array[i] = array[i] * -1 ;
}
Console.WriteLine(" новый массив  " + string.Join(" ",array));