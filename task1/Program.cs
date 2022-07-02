// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, User!");
Console.WriteLine("Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.");
int a =new Random().Next(100,999);
Console.WriteLine(a);

int c = a%100;
c = c/10;

Console.Write(" второй знак = ");
Console.Write(c);
 