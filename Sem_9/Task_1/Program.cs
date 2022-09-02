// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNumber (int number){

    if(number==0){
        return;
    }
    PrintNumber(number-1);
    Console.Write ($"{number} ");
    {
        
    }
}

PrintNumber(n);
