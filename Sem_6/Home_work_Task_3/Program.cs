// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int number1 = 0;
int number2 = 1;
int number3 = 0;

Console.Write(number1 + " " + number2 + " ");
for (int i = 3; i <= N; i++)
{
    number3 = number1 + number2;
    number1 = number2;
    number2 = number3;
    Console.Write(number3 + " ");
}

