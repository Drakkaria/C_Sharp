 // Показать последнюю цифру трёхзначного числа.

Console.Write("Здрасти! Введите пожалуйста трёхзначное число: ");
int a = int.Parse(Console.ReadLine()!);
int b = a % 10;

if (a>99&&a<1000)
{
     string str = $"Последняя цифра: {b}";
     Console.Write(str);
}
else Console.Write("Это не трех значное число, алло!");
