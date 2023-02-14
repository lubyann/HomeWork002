// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);

// int number = new Random().Next(0, 100000);


if (number < 100)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else 
{
    Console.WriteLine($"{number} -> {number.ToString()[2]}");
}