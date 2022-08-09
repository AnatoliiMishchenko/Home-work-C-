Console.WriteLine("Введите два числа");
int oneNuimber = Convert.ToInt32(Console.ReadLine());
int twoNumber = Convert.ToInt32(Console.ReadLine());
if (oneNuimber % twoNumber == 0)
{
    Console.WriteLine("Число один делиться на второе без остатка, число два \"Кратно\" первому");
}
else
{
    int ostatoc = oneNuimber % twoNumber;
    Console.WriteLine(" Остаток от деления: " + ostatoc);
}