/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. */

int a = Input("a");
int b = Input("b");
int c = Input("c");

int[,,] array3D = new int[a, b, c];

CreateArray(array3D);
WriteArray(array3D);
Console.WriteLine();

void WriteArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.Write($"a({i}) b({j}) ");
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"c({k})={array3D[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void CreateArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int a = 0; a < array3D.GetLength(0); a++)
    {
        for (int b = 0; b < array3D.GetLength(1); b++)
        {
            for (int c = 0; c < array3D.GetLength(2); c++)
            {
                array3D[a, b, c] = temp[count];
                count++;
            }
        }
    }
}

int Input(string numberName)
{
    Console.Write($"Введите значение для {numberName}: ");
    return Convert.ToInt32(Console.ReadLine());
}
