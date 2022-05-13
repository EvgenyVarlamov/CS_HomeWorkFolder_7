/* Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
1 4 7 2
5 9 2 3
8 4 2 4
Среднее аривметическое каждого столбца 4,6 5,6 3,6 3 */

Console.Write("Введите количество столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк массива: ");
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

for (int i = 0; i < n; i++)             // Цикл вывода среднеого арифметического заданного массива
{
    float averageValue = 0;
    for (int j = 0; j < m; j++)
    {
       averageValue += array[j,i];
    }
    Console.WriteLine("Среднее арифметическое столбца " + i + " равно " + Convert.ToSingle(Math.Round(averageValue/m, 1)));
}