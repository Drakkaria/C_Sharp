// Задача 14.
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine()!);

int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int g = 7;

if(day == a)
{
    Console.WriteLine ("понедельник");
    Console.WriteLine ("Будний день, надо учиться!");
}

if(day == b)
{
    Console.WriteLine ("вторник");
    Console.WriteLine ("Будний день, надо учиться!");
}
if(day == c)
{
    Console.WriteLine ("среда");
    Console.WriteLine ("Будний день, надо учиться!");
}
if(day == d)
{
    Console.WriteLine ("четверг");
    Console.WriteLine ("Будний день, надо учиться!");
}
if(day == e)
{
    Console.WriteLine ("пятница");
    Console.WriteLine ("Будний день, надо учиться! Но вечером можно в кино!");
}
if(day == f)
{
    Console.WriteLine ("суббота");
    Console.WriteLine ("Урааа! Сегодня выходной!");
}
if(day == g)
{
    Console.WriteLine ("воскресение");
    Console.WriteLine ("Урааа! Сегодня выходной!");
    }