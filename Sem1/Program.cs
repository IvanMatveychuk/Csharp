/* Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

/*Console.Clear();
Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.Write(a);
else if (a < b)
    Console.Write(b);*/

/*Console.Clear();
int [] numbers = {-2,-3};
int max = numbers.Max();
Console.WriteLine(max);*/ 

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

/*Console.Clear();
Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());
    int maxi = a;
if (b > maxi)
    maxi = b;
if (c > maxi)
    maxi = c;
Console.WriteLine(maxi);

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет 

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 ==0)

Console.WriteLine("Четное");
else
Console.WriteLine("Не четное");


/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= n; i=i+2)
Console.WriteLine(i);