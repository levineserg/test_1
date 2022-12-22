// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98


int number = new Random().Next(100, 1000);
Console.WriteLine("Ваше случайное число " + number);
int didgit1 = number/100;
int didgit2 = number % 10;
Console.WriteLine($"{didgit1}{didgit2}");


