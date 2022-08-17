// Задача 26: Напишите программу, которая принимает на вход число(А) и выдаёт сумму чисел от 12 до А.




Console.WriteLine("Введите число А");
int number = Convert.ToInt32(Console.ReadLine());


int SummaNumber(int count){
int summa = 0;
for (int i = 1 ; i <= count;i++){
    summa +=i;
}
return summa;
}


Console.WriteLine($"Сумма чисел от 1 до {number} равна {SummaNumber(number)}");
