/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

/*Console.Clear();
int sum = 0;
int t = 0;
int r = 0;
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 9999 && num < 100000)
{
for(t=num;num!=0;num=num/10)
{
r=num % 10;
sum=sum*10+r;
}
if(t==sum)
Console.Write($"{t} является палиндромом");
else
Console.Write($"{t} не является палиндромом");
}
else
Console.Write("Введите пятизначное число! ");*/



/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

/*Console.Clear();
Console.Write("x1 =  ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 =  ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1 =  ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x2 =  ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 =  ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2 =  ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 2));*/

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Clear();
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++) 
Console.WriteLine(Math.Pow(i, 3));