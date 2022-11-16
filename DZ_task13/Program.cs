Console.WriteLine("введите первое число");
string digit = Console.ReadLine();
if (digit.Length >= 3 & digit[0] != '-'){Console.WriteLine(digit[2]);}
else if (digit[0] == '-' & digit.Length > 3 ){Console.WriteLine(digit[3]);}
else{Console.WriteLine("третьего числа нет");}



