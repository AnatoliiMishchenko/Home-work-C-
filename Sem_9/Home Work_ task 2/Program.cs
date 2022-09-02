// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
int summ = 0;
int SummNumber(int number, int number1)
{
    if (number - 1 == number1)
    {
        return summ;
    }

    SummNumber(number + 1, number1);
    summ += number;
    return summ;
}
Console.WriteLine(SummNumber(n, m));

