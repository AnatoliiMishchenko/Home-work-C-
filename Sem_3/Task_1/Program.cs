int[] point = new int[2];
Console.WriteLine("Введите коорзинату Х");
point[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коорзинату Y");
point[1] = Convert.ToInt32(Console.ReadLine());
if (point[0] > 0 && point[1] > 0)
{
    Console.WriteLine("Первая половина");
}
else if (point[0] < 0 && point[1] > 0)
{
    Console.WriteLine("Вторая половина");
}
if (point[0] < 0 && point[1] < 0)
{
    Console.WriteLine("Третья половина");
}
else if (point[0] > 0 && point[1] < 0)
{
    Console.WriteLine("Четвертая половина");
}
else
{
    Console.WriteLine("на пересечении осей");
}
