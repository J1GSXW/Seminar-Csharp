//Task 1.Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
    
//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(100, 1000);

//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int ShowSum(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     if(array[i] % 2 == 0)
//     count++;
//     return count;
// }

// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size);
// ShowArray(newArray);

// int result = ShowSum(newArray);
// Console.WriteLine($"Количество чётных чисел в массиве = {result}");

//Task 2. Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
    
//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int FindSum(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     if (i % 2 != 0)
//     sum = sum + array[i];
//     return sum;
// }


// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// int result = FindSum(newArray);
// Console.WriteLine($"Суммы элементов, стоящих на нечётных индексах = {result}");

//Task 3. Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

// double[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     double[] array = new double[size];
    
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
//         array[i] = Math.Round(array[i], 2);
//     }
//     return array;
// }

// void ShowArray(double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write($"[{array[i]}] ");
//     Console.WriteLine();
// }

// double FindMax(double[] array)
// {
//     double max = array[0];
//     for(int i = 0; i < array.Length; i++)
//     if(max < array[i]) max = array[i];
//     return max;
// }

// double FindMin(double[] array)
// {
//     double min = array[0];
//     for(int i = 0; i < array.Length; i++)
//     if(min > array[i]) min = array[i];
//     return min;
// }

// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// double maxElement = FindMax(newArray);
// double minElement = FindMin(newArray);
// double difference = maxElement - minElement;
// Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {difference}");