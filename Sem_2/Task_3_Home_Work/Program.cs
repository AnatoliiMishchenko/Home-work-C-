Console.WriteLine("Введите число");
int day = Convert.ToInt32(Console.ReadLine());
if(day > 0 && day <=7){
string dayOff = (day >=6 && day <=7)?" Да, этот день выходной":" Нет, этот день рабочий";
Console.WriteLine(dayOff);
}
else{
    Console.WriteLine("Введенное вами чиcло не является днем недели :(! ");
}

