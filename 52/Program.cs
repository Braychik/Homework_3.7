/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
 using System;
using static System.Console;


Clear();
Write("Введите число строк: ");
int rows = int.Parse(ReadLine());
Write("Введите число столбцов: ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
//double [] doubleArray = ArithMeanColumns(array, columns, rows);
//WriteLine(string.Join(", ", doubleArray));


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
/* double[] ArithMeanColumns(int[,] inArray, int a, int b)
{
    double[] result = new double[a];
        for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1);)
        {
           result[j] += array[i, j] / b;
           j++;
        }
    }
     return result;
}  */

Console.WriteLine("---------------------------");
Console.WriteLine(rows);
for (int j = 0; j < rows; j++)
{
    double sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{ sum / rows} ");
}