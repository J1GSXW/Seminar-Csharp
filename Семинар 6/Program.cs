//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

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

// void ReversArray(int[] array)
// {
//     for(int left = 0, right = array.Length -1; left < right; left++, right--)
//     {
//         int temp = array[left];
//         array[left] = array[right];
//         array[right] = temp;
//     }
// }

// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// int[] array2 = newArray;
// ReversArray(array2);
// ShowArray(array2);


//Напишите программу, которая принимает на вход три числа
//и проверяет, может ли существовать треугольник с сторонами такой длины.

// bool Triangle(int a, int b, int c)
// {
//     if (a < b + c && b < a + c && c < a + b) return true;
//     return false;
// }
// Console.WriteLine("Введите А: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите C: ");
// int c = Convert.ToInt32(Console.ReadLine());

// bool result = Triangle(a,b,c);
// Console.WriteLine(result);

//Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

// int[] Fibbonacci(int size)
// {
// int[] febArray = new int[size];
// febArray[0] = 0;
// febArray[1] = 1;
// for(int i = 2; i < size; i++)
// {
// febArray[i] = febArray[i - 2] + febArray[i - 1];
// }
// return febArray;
// }

// Console.WriteLine("Сколько чисел Фиббоначи нужно вывести ?");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] fibbArray = Fibbonacci(size);
// ShowArray(fibbArray);

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }


//Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования.

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

// int[] CopyArray(int[] array)
// {
//     int[] newArray = new int[array.Length];
//     for(int i = 0; i < array.Length; i++)
//     {
//         newArray[i] = array[i];
//     }
//     return newArray;
// }

// void ReversArray(int[] array)
// {
//     for(int left = 0, right = array.Length -1; left < right; left++, right--)
//     {
//         int temp = array[left];
//         array[left] = array[right];
//         array[right] = temp;
//     }
// }


// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, min, max);
// ShowArray(array);

// int[] newArray = CopyArray(array);
// ReversArray(newArray);
// ShowArray(newArray);

// ShowArray(array);

