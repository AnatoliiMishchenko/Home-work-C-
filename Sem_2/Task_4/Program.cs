Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Введеное вами число катно 23 и 7 : " + number);
}
else
{
    Console.WriteLine("Введеное вами число не катно 23 и 7 : " + number);
}