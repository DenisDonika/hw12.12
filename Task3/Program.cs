//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-10, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Average(int[,] array)
{
    int sum = 0;
    int j = 0;
    //for (int j = 0; j < array.GetLength(1); j++)
    //{
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            
        }
            double average = sum/array.GetLength(0);
        Console.WriteLine($"{average}");
        
    //}
   
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
//Console.WriteLine($"{Average(array)}");
Average(array);