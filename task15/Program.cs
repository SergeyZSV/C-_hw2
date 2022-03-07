//  Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void WeekDay(int day)
{
    while((day < 1) | (day > 7))
    {
        Console.Write("Вы ввели неверное число. Введите заново: ");
        day = Convert.ToInt32(Console.ReadLine());
    }
    if((day == 6) | (day == 7)) Console.WriteLine("Выходной.");
    else Console.WriteLine("Рабочний день.");
}

Console.Write("Введите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());
WeekDay(a);