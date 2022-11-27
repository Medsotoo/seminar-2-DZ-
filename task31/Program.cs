Console.WriteLine("введите длинну массива");
int count = Convert.ToInt32(Console.ReadLine());


int [] array = new int [count];

for (int i = 0; i < count; i++)
{
    array[i] = new Random().Next(-9,10);
    Console.Write(" " + array[i]);
}

Console.WriteLine();

for(int i = 0; i < count; i++)
{
    if (array[i] < 0){array[i] = Math.Abs(array[i]);}
    else{array[i] = -(array[i]); }
    Console.Write(" " + array[i]);
}