﻿// Задача 15: Напишите программу, которая 
//     принимает на вход цифру, обозначающую день недели, 
//     и проверяет, является ли этот день выходным.
//         6 -> да 
//         7 -> да 
//         1 -> нет

Console.WriteLine("Вас приветствует Нанедельник посещений.");
Console.WriteLine("На какойдень надели Вы хотели бы записаться?");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5)
{
    Console.WriteLine("К сожалению, на этот день записи нет :(");
    Console.WriteLine("Верьте, что в следующий раз Вам точно повезёт!)");
}
else if (day == 6 || day == 7)
{
    Console.WriteLine("Вы правда расчитывали записаться на выходной??");
}
else { Console.WriteLine("В отпуске"); }