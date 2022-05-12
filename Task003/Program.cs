/* Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
 */

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0 ; j < n; j++)
    {
        array[i,j] = new Random().Next(0, 10);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0 ; j < n; j++)
    {
        if (i % 2 == 1 && j % 2 == 1)
        {
            array[i,j] *= array[i,j];
        }
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}