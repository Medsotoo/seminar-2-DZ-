Console.WriteLine("введите пятизначное число");
string numb = Console.ReadLine();
int sum = 0;

for (int i = 1; i < 3; i++)
{
    if (numb[i - 1] == numb[^i])
    {
        sum += 1;
    }

}

if (numb.Length < 5 || numb.Length > 5) { Console.WriteLine("число не пятизначное"); }
else if (sum == 2){Console.WriteLine("число палиндром");}
else{Console.WriteLine("число не палиндром");}
