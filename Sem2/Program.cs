/* array
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-10, 11); // [-10;10]

Console.WriteLine($"[{string.Join(", ", array)}]");*/

        /*ПРОЦЕДУРЫ
Console.Clear();

void f(ref int x)
{
    x = x + 10;
    Console.WriteLine(x);
}

int n = 5;
Console.WriteLine(n);
f (ref n);
Console.WriteLine(n);*/

/* ФУНКЦИИ
Console.Clear();

string f(int a, int b)
{
if (a > b)
return ">";
return "<";
}

Console.WriteLine(f(10, 5));

*/ 
// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8


/*Console.Clear();
int f(int n)
{
int n1 = n / 10;
int n2 = n % 10;
    if (n1 > n2)
    return n1;
    return n2;
}

int n = new Random().Next(10, 100); // [10, 99]
Console.WriteLine(n);
Console.WriteLine(f(n));*/

/*Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98*/

/*Console.Clear();
int n = new Random().Next(100, 1000); // [100, 999]
Console.WriteLine(n);
int n1 = n / 100;
int n3 = n % 10;
Console.WriteLine(n1*10+n3);

/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно*/

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
if (n % z == 0)
    Console.WriteLine("кратно");
else 
Console.WriteLine($"не кратно, остаток {n % z}");