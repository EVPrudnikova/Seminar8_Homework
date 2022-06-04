/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7  */


int m = Input("m");
int n = Input("n");

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int[,] newArray = new int[m-1,n-1];

int row = 0;
int column = 0;
int minValue = array[0, 0];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if(array[i, j] < minValue)
        {
            minValue = array[i, j];
            row = i;
            column = j;
        }
    }
}

Console.WriteLine("Минимальный элемент массива - " + minValue + ", " + "с координатами: " + row + ", " + column);

int positionA = 0;
int positionB = 0;

for (int i = 0; i < newArray.GetLength(0); i++)
{
    if(positionA == row)
    {
        positionA++;
    }
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        if(positionB == column)
        {
            positionB++;
        }
        newArray[i,j] = array[positionA, positionB];
        positionB++;
    }
    positionB = 0;
    positionA++;
}

Console.WriteLine("Итоговый массив: ");
PrintArray(newArray);

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
            matrix[rows, columns] = new Random().Next(1, 11);
        }
    }
}
int Input(string numberName)
{
    Console.Write($"Введите значение для {numberName}: ");
    return Convert.ToInt32(Console.ReadLine());
}
