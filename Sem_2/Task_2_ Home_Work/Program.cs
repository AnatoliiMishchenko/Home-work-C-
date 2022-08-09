Console.WriteLine("Введите число");
string number = Console.ReadLine();
int number1 = Convert.ToInt32(number);
int freeNumber = 0;
if (number1 < 999 && number1 > -999)
{
    if (number1 > 99 || number1 < -99)
    {
        freeNumber = number1 > 0 ? (number1 % 10) : (number1 % 10 * (-1));
        Console.WriteLine($"Третья цифра в числе {number1} " + " будет " + freeNumber);
    }
    else
    {
        Console.WriteLine("Введенное число не имеет третьей цифры");
    }
}
else
{
    freeNumber = Convert.ToInt32(number[2].ToString());
    Console.WriteLine($"Третья цифра в числе {number1} будет " + freeNumber);
}
