int number = new Random().Next(100,1000);
Console.WriteLine("Наше число : " + number);
int oneNumber = number / 100;
int freeNubmer = number % 10;
Console.WriteLine(  $"Наше искомое число:  {oneNumber}{freeNubmer}");
