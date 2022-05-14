/* Задача 47. Задайте двумерный массив размером mxn,
заполненный случайными вещественными числами.
m=3, n=4
0,5  7  -2  -0,2
1  -3,3  8  -9,9
8   7,8 -7,1  9*/

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0 ; j < n; j++)
    {
        array[i,j] = Math.Round(Convert.ToDouble(new Random().Next(-99, 100))/10, 1);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}