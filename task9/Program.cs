int number = new Random().Next(10, 100);
Console.WriteLine("Ваше случайное число " + number);
int didgit1 = number/10;
int didgit2 = number % 10;
if(didgit1 > didgit2)
{
    Console.WriteLine("Первая цифра больше второй");
}
else
{
    Console.WriteLine("Вторая цифра больше первой");
}
