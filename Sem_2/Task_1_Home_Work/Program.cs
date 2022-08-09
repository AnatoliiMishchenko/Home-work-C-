Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if ((number < 999 && number > 99) || (number > -999 && number < -99))
{

    int twoNumber = (number < 0) ? ((number - number / 100 * 100) / (-10)) : ((number - number / 100 * 100) / 10);
    Console.WriteLine("Второе число в числе " + number + " является " + twoNumber);
}
else
{
    Console.WriteLine("Введеное вами число не трехзначное");
}