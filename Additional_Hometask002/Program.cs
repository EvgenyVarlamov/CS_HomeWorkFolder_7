/* Написать 2 функции для работы с массивом: AddToArray И RemoveFromArray – первая 
добавляет к числовому массиву значение, тем самым увеличивая массив, 
а вторая удаляет элемент под нужным индексом и уменьшает массив на 1. */

Console.WriteLine();
Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arrayCurrent = new int[length];

FillArray(arrayCurrent);
Console.WriteLine("Текущий массив: ");
PrintArray(arrayCurrent);
Console.WriteLine();
Console.WriteLine("Увеличеный массив: ");
AddToArray(arrayCurrent);
Console.WriteLine();
Console.WriteLine("Сокращенный массив: ");
RemoveFromArray(arrayCurrent);
Console.WriteLine();

void FillArray(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("{ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "}");
    Console.WriteLine();
}

void AddToArray(int[] arr)
{
    int[] arrayPlus = new int[arr.Length + 1];

    for (int i = 0; i < arr.Length; i++)
    {
        arrayPlus[i] = arr[i];        
    }

    arrayPlus[arrayPlus.Length - 1] = new Random().Next(0, 10);
    
    PrintArray(arrayPlus);
}

void RemoveFromArray(int[] arr)
{
    int index = 0;

    while (true)
    {        
        Console.Write("Введите индекс элемента массива, который нужно удалить : ");
        index = Convert.ToInt32(Console.ReadLine());
        if (index >= arr.Length)
        {
            Console.WriteLine($"Индекс не должен быть больше {arr.Length - 1}");
        }
        else
        {
            break;
        }
    }
    
    int[] arrayMinus = new int[arr.Length - 1];
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i == index)
        {
            continue;
        }
        arrayMinus[count] = arr[i];
        count++;
    }
    Console.WriteLine();
    PrintArray(arrayMinus);
}