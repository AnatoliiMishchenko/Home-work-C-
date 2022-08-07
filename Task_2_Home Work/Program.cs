Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a > b && a > c )
{
    max = a;    
}
else if (b > a && b > c)
{
    max = b;   
}
else if (c > a && c > b )
{
    max = c;    
}
Console.WriteLine("Максимальное число = " + max);