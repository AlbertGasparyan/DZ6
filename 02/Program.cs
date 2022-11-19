//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
System.Console.Clear();

int rows = ReadMessage("Введите индекс строки: ");
int colums = ReadMessage("Введите индекс столбца: ");



int [,] matrix = new int [3,4];

FillArary(matrix);
PrintImage(matrix);

if (rows < matrix.GetLength(0) && colums < matrix.GetLength(1)) Console.WriteLine(matrix[rows, colums]);
else Console.WriteLine($"[{rows},{colums}] -> такого числа в массиве нет");



void FillArary (int [,] array) // получение двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintImage (int [,] image) // Печать массива на экран
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            System.Console.Write($"{image[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

int ReadMessage(String message) // функция ввода
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()??"0");
}