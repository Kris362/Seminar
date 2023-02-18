﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Clear();
Console.WriteLine("Введите любое число больше 100 или меньше -100 ");

int tree = int.Parse(Console.ReadLine()!);

int n = 1;
int tree2 = 0;

if (tree < 0)
{
    tree = -tree;
}
if (tree / 100 > 0)
{
    while (tree / n > 999)
    {
        n = n * 10;
    }
    tree2 = (tree / n) % 10;
    Console.WriteLine(tree2);
}
else
{
Console.WriteLine("Третьей цифры нет");
}