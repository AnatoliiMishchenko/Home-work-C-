Console.WriteLine("Введите первое чило!");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе чило!");
int b = Convert.ToInt32(Console.ReadLine());
int max = a > b ? a : b;
int min = a > b ? b : a;
Console.WriteLine("Максимальное число " + max);
Console.Write("Минимальное число " + min);