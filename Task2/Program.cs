// //Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
// и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-20, 21);
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

int Check(int num, int[,] array)
{


    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (num == array[i, j]) Console.WriteLine($"Позиция {num} есть [{i},{j}]");


            else Console.WriteLine($"Такого числа в массиве нет");
    return num;
}






Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
Check(num, array);



//Console.WriteLine(" отсутствует в данном массиве");
