// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


//Console.Clear();

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);

//int number = new Random().Next(100, 1000);

int result = number % 100 / 10;
Console.WriteLine($"{number} -> {result}");