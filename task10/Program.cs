int numb = new Random().Next(100,1000);
Console.WriteLine($"случайное число {numb}");
Console.WriteLine($"новое число бе цифры посередине {(numb / 100 * 10) + numb % 10}");
