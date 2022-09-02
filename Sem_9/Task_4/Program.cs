
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
int cout = 1;

int PrintNumber(int number, int number1)
{
    if (number == 0)
    {
     cout = 0;
     return cout;
    }
    else
    {
        if (number1 == 0)
        {
            return cout;
        }
        cout *= number;

        PrintNumber(number, number1 - 1);
        return cout;

    }
}

Console.WriteLine(PrintNumber(n, m));
