﻿/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int NumbR(int m, int n)
{
    if (n == m)
    {
        return n;
    }
    Console.WriteLine(n);
    return NumbR(m, n - 1);
}
Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int f = NumbR(m, n);
Console.WriteLine(f);