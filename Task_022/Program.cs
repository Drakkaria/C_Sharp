// Задача №22 
// Задайте массив из 10 элементов из промежутка [-9, 9] и положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = new int [10];

Console.Write("[");
for (int i = 0; i <array.Length; i++)

{
    int randomNumber = new Random().Next(-9, 10);
    array [i] = randomNumber;
    Console.Write(array [i].ToString() + ", ");
    
}
Console.Write("] -> ");

Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array [i] = (array [i] * -1);
    Console.Write(array [i].ToString() + ", ");
}
Console.Write("]");



//Console.Write(randomNumber);
// {
//     array[i] = new Random().Next(-10, 10);
//     string elements = Convert.ToString(array[i]);
//     int convert = Convert.ToInt32(elements);
//     Console.Write(convert.ToString() + ", ");
//}
