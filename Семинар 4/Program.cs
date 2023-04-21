// int GetSum(int num)
// {
//     int sum = 0;

//     for(int current = 1; current <= num; current++)
//         sum = sum + current;

//     return sum;
// }
// Console.Write("Input a number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int res = GetSum(a);
// Console.WriteLine($"Sum of numbers 1 to {a} is {res}");

// Task 1. Напишите программу, которая 
// принимает на вход число и выдаёт количество цифр в числе.
// int CountNum(int num)
// {
//     int count = 0;
//     while(num > 0)
//     {
//         num = num / 10;
//         count ++;
//     }
//     return count;
// }
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Цифр в числе {number} {CountNum(number)}");


// Напишите программу, которая принимает
// на вход число N и выдаёт произведение чисел от 1 до N.
// int MultNum(int num)
// {
//     int step = 1;
//     int fact = 1;
//     while (step <= num)
//     {
//         fact = fact * step;
//         step++;
//     }
//     return fact;
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Факториал числа {num} = {MultNum(num)}");


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

// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);