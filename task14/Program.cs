﻿// Задача 14: Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

Console.WriteLine("Введите число:");
int numberA=Convert.ToInt32(Console.ReadLine());

if (numberA%7==0 & numberA%23==0)
{
    Console.Write ("кратно 7 и 23");
}
else
{
    Console.Write ("не кратно");
}