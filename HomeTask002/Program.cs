/* Задача 50. Напишите программу, которая на вход принимает
позиции элемента в двумерном массиве, и возвращает значение
этого элемента иле же указание, что такого элемента нет.
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет */

Console.Write("Введите столбец, от 0 и выше: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите строку, от 0 и выше: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[new Random().Next(2, 10),new Random().Next(2, 10)];

for (int i = 0; i < array.GetLength(0); i++)                 // Цикл создания вывода двумерного массива
{
    for (int j = 0 ; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0, 10);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

if (m < array.GetLength(0) && n < array.GetLength(1))        // Проверка существования в двумерном массиве введенной позиции
{
    Console.WriteLine($"Элемент массива [{m},{n}] = {array[m,n]}");
}
else
{
    Console.WriteLine($"Размер массива {array.GetLength(0)}x{array.GetLength(1)}");
    Console.Write($"Последний элемент массива [{array.GetLength(0)-1},{array.GetLength(1)-1}]");
    Console.WriteLine($" = {array[array.GetLength(0)-1,array.GetLength(1)-1]}");
    Console.WriteLine($"Введенной вами позиции [{m},{n}] в массиве не существует");
}