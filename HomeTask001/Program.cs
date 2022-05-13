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

float[,] array = new float[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0 ; j < n; j++)
    {
        float temporaryValue = new Random().Next(-99, 100); // без временной переменной выдаёт только целые числа
        array[i,j] = temporaryValue / 10; // работет также как и такая запись: array[i,j] = Convert.ToSingle(Math.Round(temporaryValue/10, 1));
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}