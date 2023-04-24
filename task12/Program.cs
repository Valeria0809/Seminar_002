// Напишите программу, которая будет принимать два числа и выводить, является ли
// второе число кратным первому. если число 2 не кратно числу 1, то программа
// выводит остаток от деления

System.Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1%num2 == 0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine(num1%num2);
}