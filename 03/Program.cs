// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

System.Console.Clear();

double[,] matrix = new double[3, 4];

FillArary(matrix);
PrintImage(matrix);
System.Console.WriteLine();
SumArray(matrix);

void FillArary(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(1, 10));
        }
    }
}

void PrintImage(double[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            System.Console.Write($"{image[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void SumArray(double[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Среднее африсетическое = {sum / array.GetLength(0)}; ");
    }
}
