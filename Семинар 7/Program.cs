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



// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);





//Задайте двумерный массив размером M на N,
//каждый элемент которого будет находиться по формуле 
//A[i,g] = i + j, выведите полученный массив на экран

// int[,] Create2dArray(int rows, int columns)
// {

//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = i+j;

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


//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
// int[,] newArray = Create2dArray(rows, columns);
// Show2dArray(newArray);

//Задайте двумерный массив, найдите элементы у которых
//оба индекса чётные, замените эти элемениты на их квадраты.

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

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void QuadrantArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i += 2)
//         for (int j = 0; j < array.GetLength(1); j += 2)
//         {
//             array[i, j] = array[i, j] * array[i, j];
//         }
// }



// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// QuadrantArray(myArray);
// Show2dArray(myArray);

//Задайте двумерный массив, найдите сумму элементов,
//находящихся на главной диагонали.

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

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int SumMatrix(int[,] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         result = result + array[i,i];
//     return result;
// }



// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// int result = SumMatrix(myArray);
// Console.WriteLine(result);