﻿/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите целое пятизначное число: ");
int N = int.Parse(Console.ReadLine() ?? "");
int i1 = N / 10000;
int i2 = N /1000 % 10;
int i4 = N % 100 / 10;
int i5 = N % 10;

if (i1 == i5 && i2 == i4)
    Console.WriteLine($"Число {N} является палиндромом");
else
    Console.WriteLine($"Число {N} не является палиндромом");