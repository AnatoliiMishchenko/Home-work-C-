int number = new Random().Next(10, 100);
Console.WriteLine("Наше случайное чилсо: " + number);
int oneNumber = number / 10;
int twonumber = number % 10;
int max = oneNumber > twonumber ? oneNumber : twonumber;
Console.WriteLine($"Наше максимальное чилсо: {max}");



