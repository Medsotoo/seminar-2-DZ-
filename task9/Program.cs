
int numb = new Random().Next(10, 100);
Console.WriteLine($"Случайное число {numb}");
if ((numb / 10) > (numb % 10)) {Console.WriteLine(numb / 10);}
else {Console.WriteLine(numb % 10);}
