// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());

void PrintNumber(int number, int number1)
{
    if (n > m)
    {

        if (number == number1 - 1)
        {
            return;
        }
        PrintNumber(number - 1, number1);
        Console.Write($"{number} ");
    }
    else
    {
        if (number1 == number - 1)
        {
            return;
        }
        PrintNumber(number + 1, number1);
        Console.Write($"{number} ");
    }
}

PrintNumber(n, m);