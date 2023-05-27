// Задача №29.
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример:
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите циферки пж, ток через пробел нада: ");
int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int count = 0;

for (int i = 0; i <arr.Length; i++)
{
    if(arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество циферок больше нуля: {count} ");
