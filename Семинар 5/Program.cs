// Задайте массив из 12 элементов, заполненный случайными
//  числами из промежутка [-9, 9]. 
//  Найдите сумму отрицательных элементов массива.

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

// int GetNegativeSum(int[] array)
// {
//     int sum = 0;

//     for(int i = 0; i < array.Length; i++ )
//         if (array[i] < 0)
//             sum += array[i]; //то же самое, что и sum = sum + array[i];
// return sum;
// }
//a = a + c, то же самое, что и a += c;


// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// int result = GetNegativeSum(newArray);
// Console.WriteLine("Sum of negative elements is " + result);

//Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие
// отрицательные, и наоборот.

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

// int[] ChangeNegativeElements(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     array[i] *= -1;
//     return array;
// }

// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);
// int[] result = ChangeNegativeElements(newArray);
// ShowArray(result);

//Напишите программу, которая определяет, существует
//существует ли заданное число в массиве
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

// bool ArrayFindNumber(int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//         if(array[i] == num)
//             return true;
//      return false;

// }

// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a number, what you want find: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);
// bool result = ArrayFindNumber(newArray, num);
// Console.WriteLine(result);


// Задайте ондомерный массив из "N" случайных чисел
// Найдите количество элементов массива, значение
// которых лежат в отрезке от А до B.

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

// int FindNum(int[] array, int a, int b)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     if (array[i] >= a && array[i] <= b)
//     count ++;
//     return count;
// }

// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число А: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);
// int result = FindNum(newArray, a, b);
// Console.WriteLine($"Количество числел, в диапазоне от А до B равно {result}");

//Найти произведение пары чисел в массиве
//Парой считаем первый и последний элемент,
//второй и предпоследний и т.д. Результат запишите в новом массиве

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

// int[] FindNum(int[] array)
// {
//     int[] newArray = new int [array.Length / 2];
//     for (int i = 0; i < newArray.Length; i++)
//     newArray[i] = array[i] * array[array.Length -1 - i];
//     return newArray;
// }

// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);
// int[] result = FindNum(newArray);
// ShowArray(result);



