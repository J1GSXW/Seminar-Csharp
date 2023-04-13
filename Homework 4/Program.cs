//Task 1.
//Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
// int SquareFind (int num1, int num2)
// {
//     int step = num1;
//     for(int count = 1;count < num2;count++)
//     step = step * num1;
//     return step;
// }

// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int result = SquareFind(a,b);
// Console.Write($"Число {a} в степени {b} равно {result}");

//Task 2.
//Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

// int SummFind(int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         int i = num % 10;
//         num = num / 10;
//         sum = sum + i;
//     }
//     return sum;
// }

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = SummFind(number);
// Console.WriteLine($"Сумма всех цифр в числе {number} равна {result}");

//Task 3.
//Напишите программу, 
//которая задаёт массив из 8 элементов
// и выводит их на экран.
// int[] CreateArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//         return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i<array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// Console.Write("Задайте размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateArray(size, min, max);
// ShowArray(newArray);