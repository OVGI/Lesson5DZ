/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] array = new int[4];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-99, 99);

int k = 0;

for (int i = 1; i < array.Length; i += 2)
    k += array[i];

Console.Write("[");
for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]}, ");
Console.Write("]");
Console.Write($" -> {k}");