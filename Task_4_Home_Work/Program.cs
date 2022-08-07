Console.WriteLine("Введите чило");
int number = Convert.ToInt32(Console.ReadLine());
for( int i = 1 ; i <= number ; i+=1){
    if (i % 2 ==0){
    Console.Write(i );
    if(i < number-1){
        Console.Write(" , ");
    }
    }
}
