// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трехзначное число ");
int nuber = Convert.ToInt32(Console.ReadLine());

if ((nuber > 99) && (nuber < 1000)) 
{
    int secondNumber = (nuber / 10) % 10;
    Console.WriteLine($"Вторая цифра числа {nuber} - {secondNumber}");
}
else Console.WriteLine("Неподходящие число");