// Задача 13.1: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.(Массив)

Console.Clear();
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int bufferNumber = number;

if (number < 100)
    Console.WriteLine("В введеном числе нет третьей цифры");
else
{
    var array = new List<int>();
    while (number > 0)
    {
        array.Add(number % 10);
        number = number / 10;
    }
array.Reverse();
Console.WriteLine ($"Третье цифра чилса {bufferNumber} - {array[2]}");
}