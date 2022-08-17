// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());
int nw = Math.Abs(number2);
string? number = Convert.ToString(nw);
int count = number.Length;

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int n = 0;

if(number1==0){
    ++n;
}
while (Math.Abs(number1) > 0)
{
    number1 = Math.Abs(number1 / 10);
    
    n++;
}

Console.WriteLine(n);
Console.WriteLine(count);