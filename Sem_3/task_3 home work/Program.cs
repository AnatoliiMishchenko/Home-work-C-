Console.WriteLine("Введите число N ");

int number = Convert.ToInt32(Console.ReadLine());
Console.Write( "\n");
if(number > 0){
int count = 1;
while (count <= number)
{
    double cubeNumber = Math.Pow(count, 3);
    Console.Write(cubeNumber + " ");
    count++;
}
Console.WriteLine( "\n");
Console.WriteLine("+++++++++++++++++++");
Console.WriteLine();

for (int i = 1; i <= number; i++)
{
    double cubeNumber = Math.Pow(i, 3);
    Console.Write(cubeNumber + " ");
}
}
else{
    Console.WriteLine("Введенное число отрицательное");
}