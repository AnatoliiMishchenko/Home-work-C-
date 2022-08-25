// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
Console.WriteLine("Введите три стороны треугольника");
double A = Convert.ToDouble(Console.ReadLine());
double B = Convert.ToDouble(Console.ReadLine());
double C = Convert.ToDouble(Console.ReadLine());


string triangel(double A, double B, double C)
{
    string str = "";
    if (A + B > C)
    {
        str = "Треугольник существует";
    }
    else if (A + C > B)
    {
        str = "Треугольник существует";
    }
    else if (C + B > A)
    {
        str = "Треугольник существует";
    }
    else
    {
        str = "Треугольник несуществует";
    }
    return str;
}
Console.WriteLine(triangel(A, B, C));