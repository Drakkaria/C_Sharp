﻿ // Найти максимальное из трех чисел.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int с = int.Parse(Console.ReadLine()!);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (с > max) max = с;

string str = $"Максимальное число = {max}." ;
Console.WriteLine(str);

// Пишем запрос и ввод трех отдельных чисел
// Задаем переменную максимального числа
// Ставим условие которое переберет 3 числа и выведет максимальное.
// Переменная строка выводит максимальное число
// 
