// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] newArray = CreateNewDoubleArray(3, 4);

double[,] CreateNewDoubleArray(int m, int n)
{
    double[,] newArray = new double[m, n];

    Random digit = new Random();

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = Math.Round(10 * digit.NextDouble(), 2);
        }
    }

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{newArray[i, j]} ");
        }
        Console.WriteLine();
    }

    return newArray;
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int i = ReadInt("Введите номер строки");
int j = ReadInt("Введите номер столбца");

int ReadInt(string arg)
{
	Console.Write($" {arg}: ");
	int i;

	while (!int.TryParse(Console.ReadLine(), out i))
	{
		Console.WriteLine("Try again");
	}

	return i;
}

FindElement(i, j, newArray);

void FindElement(int i, int j, double[,] newArray)
{

    if (i > newArray.GetLength(0) || j > newArray.GetLength(1))
    {
        Console.Write("Такого элемента не существует");
    }

    else
    {
        Console.Write($"Искомый элемент "+ newArray[i - 1, j - 1]);
        Console.WriteLine();
    }
}

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] newIntArray = CreateNewIntArray(3, 5);

int[,] CreateNewIntArray(int i, int j)
{
    int[,] newIntArray = new int[i, j];

    Random digit = new Random();

    for (i = 0; i < newIntArray.GetLength(0); i++) // заполняем массив случайными числами
    {
        for (j = 0; j < newIntArray.GetLength(1); j++)
        {
            newIntArray[i, j] = digit.Next(0, 10);
        }
    }

    for (i = 0; i < newIntArray.GetLength(0); i++) // распечатываем массив
    {
        for (j = 0; j < newIntArray.GetLength(1); j++)
        {
            Console.Write($"{newIntArray[i, j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();

    Console.Write("Среднее арифметическое каждого столбца: ");

    for (int count = 0; count < newIntArray.GetLength(1); count++)
    {
        float result = 0;
        int countZero = 0;
        for (i = 0; i < newIntArray.GetLength(0); i++)
        {
            for (j = count; j == count; j++)
            {
                //Console.WriteLine(newIntArray[i, j]);
                result = (result + newIntArray[i, j]);
                if (newIntArray[i, j] == 0)
                {
                    countZero++;
                }
            }
        }

        result = result / (newIntArray.GetLength(0) - countZero);

        Console.Write(Math.Round(result, 2) + " ");

        Console.WriteLine();
    }

    return newIntArray;
}