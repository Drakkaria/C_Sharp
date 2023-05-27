// Выяснить является ли число чётным.

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

if (a%2==0)                                   // При делении на 2 остаток будет равено 0. 4/2=2 (остаок 0) 5/2=2.5 (остаток 5)
Console.WriteLine("четное число ");

else
Console.WriteLine("нечетное число ");
