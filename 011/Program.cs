// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

System.Console.Clear();

double [,] martix = new double [3,4];

FillArray(martix);
PrintImage(martix);
System.Console.WriteLine();





void PrintImage(double [,] image)
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

void FillArray(double [,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            image[i,j] =Convert.ToDouble(new Random().Next(-100,100))/10;
        }
    }
}

