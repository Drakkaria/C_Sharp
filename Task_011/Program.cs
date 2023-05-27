// Задача 11. 
// Является ли второе число кратным первому.  
// Если второе число не кратно числу первому, то программа выводит остаток от деления.

Console.Write("введите 1е число: ");
Double FN = Double.Parse(Console.ReadLine()!);

Console.Write("введите 2е число:");
Double SN = Double.Parse(Console.ReadLine()!);

if (FN % SN == 0)
Console.Write("1е число кратно 2му");
    
else
{
    Console.Write("вывод остатка: ");
    Console.WriteLine( FN%SN );
}