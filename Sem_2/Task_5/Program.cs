Console.WriteLine("Введите два числа");
int oneNumber = Convert.ToInt32(Console.ReadLine());
int twoNumber = Convert.ToInt32(Console.ReadLine());
string name = (twoNumber / oneNumber == oneNumber || oneNumber/twoNumber == twoNumber) ? "Введенное число является квадратом второго" :
"Введенное число не является квадратом второго";
Console.WriteLine(name);