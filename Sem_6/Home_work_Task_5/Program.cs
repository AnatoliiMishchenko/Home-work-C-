// Дополнительная задача на рекурсию
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. (использовать рекурсию)
// 4 -> 24
// 5 -> 120
Console.WriteLine("Hello, World!");
int count = Convert.ToInt32(Console.ReadLine());

double Factorial(int count)
{
    if (count == 1)
    {
        return count;
    }
    else
    {
        return count * Factorial(count - 1);
    }
}
Console.WriteLine(Factorial(count));