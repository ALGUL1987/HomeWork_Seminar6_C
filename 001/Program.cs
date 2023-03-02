/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
double min = new Random().Next();
double max = new Random().Next();

double[] array = GetArray(size, min, max);
double[] GetArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число: ");
        result[i] = Convert.ToDouble(Console.ReadLine());
    }
    return result;
}
int count=0;
for (int i = 0; i < size; i++)
{
    if (array[i]>0)
    {
        count++;
    }
}
Console.WriteLine($"Среди введенных чисел: {String.Join("; ", array)} чисел >0 -> {count}");

