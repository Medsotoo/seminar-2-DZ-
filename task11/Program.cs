int num1  = Convert.ToInt32(Console.ReadLine());
int numb2 = Convert.ToInt32(Console.ReadLine());
if(num1 % numb2 == 0) {Console.WriteLine($"кратно");}
else {Console.WriteLine($"не кратно, остаток {num1 % numb2}");}
