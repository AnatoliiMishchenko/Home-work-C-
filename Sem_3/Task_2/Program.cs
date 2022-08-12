Console.WriteLine("Введите четверть расположения точки");
int quarter = Convert.ToInt32(Console.ReadLine());
// switch (quarter)
// {
//     case (1):
//         Console.WriteLine(" Точка имеет координаты x > 0 y > 0");
//         break;
//     case (2):
//         Console.WriteLine(" Точка имеет координаты x < 0 y > 0");
//         break;
//     case (3):
//         Console.WriteLine(" Точка имеет координаты x < 0 y < 0");
//         break;
//     case (4):
//         Console.WriteLine(" Точка имеет координаты x > 0 y < 0");
//         break;
//     default:
//         Console.WriteLine("Данной четверти не существует");
//         break;
// }
string[] array = { "x > 0 : y > 0", "x < 0 : y > 0", " x < 0 : y < 0", " x > 0 : y < 0" };
if (quarter >=  1 && quarter <= 4)
{
    Console.WriteLine(array[quarter - 1]);
}
else
{
    Console.WriteLine("Такой четверти нет");
}

// switch(quarter){
//     case(1): Console.WriteLine(array[0]);
//     break;
//     case(2): Console.WriteLine(array[1]);
//     break;
//     case(3): Console.WriteLine(array[2]);
//     break;
//     case(4): Console.WriteLine(array[3]);
//     break;
//     default: Console.WriteLine("Такой четверти нет");
//     break;
// }


