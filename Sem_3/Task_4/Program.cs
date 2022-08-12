Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
// while(count <= number){
//     double squareNumber = Math.Pow(count,2);
//     Console.Write(squareNumber + " ");
//     count++;
// }


for( ; count <= number; count++){
    double squareNumber = Math.Pow(count,2);
   Console.Write(squareNumber + " ");
}