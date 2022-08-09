Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if ((number < 999 && number > 99) || (number > -999 && number < -99))
{
    int freeNumber = number > 0 ? (number % 10) : (number % 10 * (-1));
    Console.WriteLine($"Третья цифра в числе {number} " + " будет " +  freeNumber);
}else{
    Console.WriteLine("Введенное число не имеет третьей цифры");
}
