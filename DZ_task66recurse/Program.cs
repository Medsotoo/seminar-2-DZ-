// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumNum(int n, int m)
{
    if (n == m) return n;
    else 
    {
        return n + SumNum(n + 1,m);
    }

Console.WriteLine(SumNum(3,4));