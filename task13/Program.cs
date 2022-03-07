//  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Third_digit(int number)
{
    if(number < 100) Console.WriteLine("Третьей цифры нет.");
    else
    {
        string num_array = Convert.ToString(number);
        Console.WriteLine("Третья цифра числа " + number + ": " + num_array[2]);
    }
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Third_digit(a);