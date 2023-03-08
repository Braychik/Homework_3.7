/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */



using System;
using static System.Console;

Clear();
WriteLine("Введите число строк: ");
int rows = int.Parse(ReadLine());
WriteLine("Введите число столбцов: ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
WriteLine();

WriteLine("Введите индекс строки: ");
int inRows = int.Parse(ReadLine());
WriteLine("Введите индекс столбца: ");
int inColumns = int.Parse(ReadLine());

if(inRows < rows && inColumns < columns)
WriteLine($"{array[inRows, inColumns]}");
else
WriteLine($"{inRows}{inColumns} такого числа в масииве нет");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}