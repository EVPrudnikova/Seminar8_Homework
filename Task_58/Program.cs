/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. */

int a = Input("a");
int b = Input("b");
int c = Input("c");
int d = Input("d");

int[,] array = new int[a, b];
int[,] newArray = new int[c, d];

FillArray(array);
PrintArray(array);
Console.WriteLine();
FillArray(newArray);
PrintArray(newArray);
Console.WriteLine();

int[,] result = ProductMatrix(array, newArray);
PrintArray(result);

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) 
    {
        Console.WriteLine("Произведение двух матриц невозможно");
        return matrix1;
    }
    int[,] outputMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                outputMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return outputMatrix;
}

int Input(string numberName)
{
    Console.Write($"Введите значение для {numberName}: ");
    return Convert.ToInt32(Console.ReadLine());
}
void PrintArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1, 10);
        }
    }
}
