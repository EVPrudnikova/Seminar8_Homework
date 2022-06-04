/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов. */

int m = 4;
int n = 8;

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int minSum = 0;

for (int i = 0; i < array.GetLength(1); i++)
{
    minSum += array[0, i];
}
int minIndex = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int tempSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        tempSum += array[i, j];
    }
    Console.WriteLine($"Сумма {i} сроки: " + tempSum);
    if(minSum > tempSum)
    {
        minSum = tempSum;
        minIndex = i;
    }
}

Console.WriteLine("Строка с наименьшей суммой: " + (minIndex));

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
