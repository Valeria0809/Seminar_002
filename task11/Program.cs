// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую
// цифру этого числа 
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100,1000);
// System.Console.WriteLine(number);
// int ic = number / 100;
// int j = number % 10;
// int result = ic * 10 + j;
// System.Console.WriteLine(result);

int number = new Random().Next(100,1000);
System.Console.WriteLine(number);
System.Console.WriteLine($"{number/100}{number%10}");