// Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.

async void Rb_tr(int a, int b, int c)
{
    while((a <= 0) | (b <= 0) | (c <= 0))
    {
        Console.WriteLine("Неверные стороны треугольника.");
        Console.Write("Введите сторону A: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите сторону B: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите сторону C: ");
        c = Convert.ToInt32(Console.ReadLine());
    }
    if((a == b) | (b == c) | (c == a))
    {
        if((a == b) && (b == c) && (a == c)) Console.WriteLine("Треугольник ABC - равнобедренный равносторонний.");
        else Console.WriteLine("Треугольник ABC - равнобедренный неравносторонний.");
    }
    else Console.WriteLine("Треугольник ABC не является равнобедренным.");
}

Console.Write("Введите сторону A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону C: ");
int c = Convert.ToInt32(Console.ReadLine());

Rb_tr(a, b, c);