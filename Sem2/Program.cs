﻿/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

Console.Clear();
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n%100;
int n2 = n1/10;
     Console.WriteLine($"{n2}");*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

/*Console.Clear();
int Prompt (string message)
{
     
Console.Write(message);
string value = Console.ReadLine();

int n = Convert.ToInt32(value);
return n;
}

int GetThirdRank (int n)
{
     while (n>999)
     {
          n/=10;
     }
     return n%10;
}
bool ValidateNumber(int n)
{
     if (n<100)
     {
          Console.WriteLine("Третьей цифры нет");
          return false;
     }
     return true;

}

int number = Prompt("Введите число >");
if (ValidateNumber(number))

     Console.WriteLine(GetThirdRank (number));*/

Console.Clear();
Console.WriteLine("Введите число");

int n = Convert.ToInt32(Console.ReadLine());
     if  (n < 5 || n <6)
     Console.WriteLine("Будний день");
     else 
     Console.WriteLine("Выходной день");
