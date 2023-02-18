// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Clear();
Console.WriteLine("Введите цифру от 1 до 7 ");
int week = int.Parse(Console.ReadLine()!);

if (week > 0 && week < 6)
{
    Console.WriteLine("Сегодня будний день");
}
if (week >= 6 && week <= 7)
{
    Console.WriteLine("Сегодня выходной день");
}
