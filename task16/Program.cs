﻿// Напишите программу, которая принимает на вход два числа и проверяет, является
// ли одно число квадратом второго
// 5,25 -> да
// -4,16 -> да
// 25,5 -> да
// 8,9 -> нет

System.Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 * num1 == num2 || num2 * num2 == num1)
{
    System.Console.WriteLine("Второе число является квадратом первого");
}
else
{
    System.Console.WriteLine("Число не является квадратом другого");
}