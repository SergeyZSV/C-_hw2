//  Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе выводит перевёрнутое число.

void Mix_num (int abc)
{
    while((abc < 100) | (abc > 999))
    {
        Console.Write("Вы ввели неверное число. Введите число зановно: ");
        abc = Convert.ToInt32(Console.ReadLine());
    }
    string a = Convert.ToString(abc / 100);
    string c = Convert.ToString(abc % 10);
    string b = Convert.ToString(abc / 10 % 10);
    Console.WriteLine("Перевернутое число: " + c + b + a);
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Mix_num(number);