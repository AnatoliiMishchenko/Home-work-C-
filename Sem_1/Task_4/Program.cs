Console.WriteLine("Введите число полоджительное целое");
int number = Convert.ToInt32(Console.ReadLine());
// for( int n = - number; n <= number ; ++n){
// Console.Write(n);
// if(number > n){
//     Console.Write(" , ");
// }
// }
int count = - number;
if(count <= number){
    while(count <= number){
        Console.Write(count);
        count++;
        if(count <= number){
        Console.Write( " , ");
    }
    }
} else{
    while(count >= number){
        Console.Write(number );
    number++;
    if(count >= number){
        Console.Write( " , ");
    }
    }
}

