// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int summa = 0;

int SummaNumber (int number){
while (number > 0)
{
    int number1 = number % 10;
    summa = summa + number1;
    number = number / 10;
}
return summa;
}
Console.WriteLine(SummaNumber(number));


// Есть вопрос по данной задаче????? хотел сделдать массивом но не получилось почему???
Console.WriteLine("Введите число");
string? number2 = Console.ReadLine();
int summa2 = 0;
for (int i = 0; i < number2?.Length; i++)
{
    summa2 = summa2 + Convert.ToInt32(number2[i]);
}
Console.WriteLine(summa2);