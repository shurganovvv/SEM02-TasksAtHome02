// Задача 10: Напишите программу, которая 
//     принимает на вход трёхзначное число 
//     и на выходе показывает вторую цифру этого числа.
//         456 -> 5
//         782 -> 8 
//         918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int i;
for (i = 0; i < 3; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    // как вариант: int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    if (number > 99 && number < 1000)
    {
        // переменная по необходимости: int lastDigit = number / 10 % 10;
        System.Console.WriteLine(number / 10 % 10);
        i = 5;
    }
    else if (number < -99 && number > -1000)
    {
        // переменная по необходимости: int lastDigit = (number / 10 % 10) * -1;
        System.Console.WriteLine(-1 * number / 10 % 10);
        i = 5;
    }
    else
    {
        System.Console.WriteLine("Пожалуйста, ТРЁХзначное число!");
    }
}
if (i < 5)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Пнятненько...");
    System.Console.WriteLine(" Ошибочка вышла");
    System.Console.WriteLine("Извини...");
    System.Console.WriteLine();
}

/* для интереса усложнил себе задачу, 
понял, что поторопился, когда увидил условия второй задачи... 
наверно, надо постараться себя сдерживать? */