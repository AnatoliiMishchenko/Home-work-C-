
Console.WriteLine("Введите чило из пяти числе");

string? array = Console.ReadLine();
Console.WriteLine(array?.Length);

if (array?.Length == 5)
{
    if (array[0] == array[4] && array[1] == array[3])
    {
        Console.WriteLine("Чило введенное вами число является полидромом");
    }
    else
    {
        Console.WriteLine("Чило введенное вами число не является полидромом");

    }
}
else
{
    Console.WriteLine("Введенное вами число не пятизначное");
}

