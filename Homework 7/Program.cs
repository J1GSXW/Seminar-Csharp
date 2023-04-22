//Task 1. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
// double[,] CreateRandom2dArray()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимально допустимый элемент: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимально допустимый элемент: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     double[,] array = new double[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//         {
//             array[i,j] = new Random().Next(minValue , maxValue + 1) + new Random().NextDouble();
//             array[i,j] = Math.Round(array[i,j], 2);
//         }
//     return array;
// }


// void Show2dArray(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// double[,] new2dArray = CreateRandom2dArray();
// Show2dArray(new2dArray);

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимально допустимый элемент: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимально допустимый элемент: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue , maxValue + 1);

//     return array;
// }


// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void FindIndex(int[,] array, int pos1, int pos2)
// {
//     if(pos1 < 0 || pos2 < 0 || pos1 > array.GetLength(0) - 1 || pos2 > array.GetLength(1) - 1)
//         Console.WriteLine("Элемента с такими координатами не существует");
//     else
//         Console.WriteLine("Значение элемента массива array[{0},{1}] = {2}", pos1, pos2, array[pos1,pos2]);
// }


// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// Console.WriteLine("Введите позицию 1");
// int pos1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите позицию 2");
// int pos2 = Convert.ToInt32(Console.ReadLine());
// FindIndex(myArray, pos1, pos2);

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимально допустимый элемент: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимально допустимый элемент: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue , maxValue + 1);

//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void AverageFound(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum += array[i, j];
//     }
//     Console.Write($"{ sum / array.GetLength(0)} ");
// }
// }


// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// AverageFound(myArray);
