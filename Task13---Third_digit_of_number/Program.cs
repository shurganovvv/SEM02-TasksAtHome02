// Задача 13: Напишите программу, которая 
//     выводит третью цифру заданного числа 
//     или сообщает, что третьей цифры нет.
//         645 -> 5
//         78 -> третьей цифры нет
//         32679 -> 6

Console.WriteLine("Какими часлами побалуешь на этот раз?");
Console.WriteLine("Только давай сразу договоримся: пусть число будет не очень большим, ну, то есть в пределах -2 147 483 648 и + 2 147 483 647, хорошо?");
Console.Write("Означь: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == -2147483648) { 
    // Console.WriteLine("4, соригинальничал, да?"); 
    number = 214;
    }
else if (number < 0) { number = number * -1; }
if (number < 100) { Console.WriteLine("третьей цифры нет"); }
else
{
    while (number / 1000 > 0) { number = number / 10; }
    Console.WriteLine(number % 10);
}

/* а вот интересно, 
как нужно конвертировать Console.ReadLine()
для получения вещественного типа данных?
    int number = Convert.ToInt32(Console.ReadLine());
    double numbers = Convert.Double64(Console.ReadLine( :)));
    ? */