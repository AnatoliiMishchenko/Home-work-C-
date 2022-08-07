
Console.WriteLine("Введите два числа");
while(true){
int square = Convert.ToInt32(Console.ReadLine());   
int number = Convert.ToInt32(Console.ReadLine());
if (square/number == number){

    Console.Write("Число " + square + " является квадратом " + number);
   break;
}
else{
    Console.WriteLine("Число " + square + " не является квадратом " + number);
    Console.WriteLine("Попробуйте еще раз");
}
}
