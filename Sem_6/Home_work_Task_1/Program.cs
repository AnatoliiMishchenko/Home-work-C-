// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int count = 0;
string numberUser = string.Empty;
Console.WriteLine("Введите числа , для завершения ввода введите  0");

while(true)
{
    double number = Convert.ToDouble(Console.ReadLine());


    if (number == 0)
    {
        break;
    }
    numberUser = numberUser + Convert.ToString(number) + "  ";

    if (number > 0)
    {
        count++;

    }
}
Console.WriteLine(numberUser + $" количество положительных чисел равно {count}");


