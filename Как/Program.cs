using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите операцию (+, -, *, /):");
        char operation = char.Parse(Console.ReadLine());

        double result = operation switch
        {
            '+' => num1 + num2,
            '-' => num1 - num2,
            '*' => num1 * num2,
            '/' => num2 != 0 ? num1 / num2 : throw new ArgumentException("Ошибка: ошибка на деление на ноль бе бе бе ь."),
            _ => throw new ArgumentException("Не правильная операция бе бе бе")
        };

        Console.WriteLine($"Результат: {result}");

        Console.WriteLine("Нажмите любую клавишу для выхода.");
        Console.ReadKey();
