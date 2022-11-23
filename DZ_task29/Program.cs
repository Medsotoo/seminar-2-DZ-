Console.WriteLine("введите длинну массива");
int count = Convert.ToInt32(Console.ReadLine());


int [] array = new int [count];

for (int i = 0; i < count; i++)
{
    array[i] = new Random().Next(0,20);
    Console.Write(" " + array[i]);
}