﻿// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Print(int numM, int numN)
{
    if (numN < numM)
    {
        return;
    }
    Print(numM, numN - 1);
    System.Console.Write(numN + "\t");
}

Metka:
int m = ReadInt("Введите число M ");
int n = ReadInt("Введите число N ");
Print(m, n);

if (n <= m)
{
    System.Console.WriteLine("Нет чисел в промежутке от M до N. Повторите ввод!");
    goto Metka;
}