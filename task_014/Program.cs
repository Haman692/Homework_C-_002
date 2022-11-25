// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели ");
int number = Convert.ToInt32(Console.ReadLine());

if (0 < number && number < 8)
{
    if (number == 6 || number == 7)
        Console.WriteLine("Ура, сегодня выходной!!!");
    else 
        Console.WriteLine("Сегодня надо поработать");
}
else 
    Console.WriteLine("В не деле всего 7 дней!!!");