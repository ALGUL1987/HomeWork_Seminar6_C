/*
Задача 42 (необязательно): Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
int i = 0;
int valueCount = value;
int valueArray = value;
while (valueCount > 0)
{
    valueCount = valueCount / 2;
    i++;
}
int[] binaryValue = new int[i];
int size = i;
for (int j = 0; j < size; j++)
{
    binaryValue[size-1-j] = valueArray % 2;
    valueArray = valueArray / 2;
    i++;
}
Console.WriteLine($" Число {value} в двоичном коде {String.Join(" ", binaryValue)}");





