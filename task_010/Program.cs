// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number > 99) && (number < 1000)) 
{
    int secondNumber = (number / 10) % 10;
    Console.WriteLine($"Вторая цифра числа {number} - {secondNumber}");
}
else Console.WriteLine("Неподходящие число");