// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int bufferNumber = number;

while (number > 1000)
    number = number / 10;
if (number < 100) 
    Console.WriteLine("В введеном числе нет третьей цифры");
else
{
    int thirdNumber = number % 10;
    Console.WriteLine($"Третье цифра чилса {bufferNumber} - {thirdNumber}");
}