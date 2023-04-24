// Task 1.Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

// void SortintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }


// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// SortintArray(myArray);
// Show2dArray(myArray);

//Task 2.Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

// void NumberRowMinSumElements(int[,] array)
// {
//     int minRow = 0;
//     int minSumRow = 0;
//     int sumRow = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minRow += array[0, i];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
//         if (sumRow < minRow)
//         {
//             minRow = sumRow;
//             minSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.Write($"{minSumRow + 1} строка");
// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// NumberRowMinSumElements(myArray);

//Task 3. Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
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

// int[,] MultMatrix(int[,] array1, int[,] array2)
// {
//     int[,] resultArray = new int[array1.GetLength(0), array1.GetLength(1)];
//     if (array1.GetLength(0) != array2.GetLength(1))
//      Console.WriteLine("Невозможно перемножить ");

//     for(int i = 0; i < array1.GetLength(0); i++)
//     {
//         for(int j = 0; j < array2.GetLength(1); j++)
//         {
//             resultArray[i,j] = 0;
//             for(int k = 0; k < array1.GetLength(1); k++)
//             {
//                 resultArray[i,j] += array1[i,k] * array2[k, j];
//             }
//         }

//     }
//     return resultArray;
// }   

// int[,] firstArray = CreateRandom2dArray();
// int[,] secondArray = CreateRandom2dArray();
// int[,] resultArray = MultMatrix(firstArray,secondArray);
// Show2dArray(firstArray);
// Show2dArray(secondArray);
// Show2dArray(resultArray);

//Task 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] Create3dArray()
// {
//     int[,,] array = new int[2,2,2];
//     int count = 10;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[k,i,j] += count;
//                 count += 3;
//             }
//         }
//     }
//     return array;
// }

// void Print3dArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }

// int[,,] array3d = Create3dArray();
// Print3dArray(array3d);

//Task 5.Напишите программу, которая заполнит спирально массив 4 на 4.

// int[,] SpiralMatrix(int sideMatrix)
// {
//     int[,] squareMatrix = new int [sideMatrix, sideMatrix];
//     int temp = 1;
//     int i = 0;
//     int j = 0;
// while (temp <= squareMatrix.GetLength(0) * squareMatrix.GetLength(1))
// {
//   squareMatrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < squareMatrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= squareMatrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > squareMatrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }
//     return squareMatrix;
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         if(array[i,j] > 9)
//             Console.Write(array[i,j] + " ");
//         else 
//             Console.Write("0" + array[i,j] +" ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// Console.WriteLine("Введите сторону квадратной матрицы: ");
// int sideMatrix = Convert.ToInt32(Console.ReadLine());
// int[,] squareMatrix = SpiralMatrix(sideMatrix);
// Show2dArray(squareMatrix);
