// Задача 67:Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());

int summ = 0;
int SummNumber(int number)
{
    if (number == 0)
    {
        return summ;
    }
    int n = number % 10;
    summ += n;
    number = number / 10;

    SummNumber(number);

    return summ;
}
Console.WriteLine(SummNumber(n));
