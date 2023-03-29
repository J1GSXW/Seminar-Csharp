//Task 1.
//Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.

// int CutNumber(int num)
// {
//     int hundreds = num / 100;
//     int units = num % 10;

//     int result = hundreds * 10 + units;
//     return result;
// }


// int randNumber = new Random().Next(100, 1000);
// int newNumber = CutNumber(randNumber);

// Console.WriteLine($"New version of {randNumber} is {newNumber}");

//Task 2.
// Напишите программу, которая выводит
//  случайное число из отрезка [10, 99]
//  и показывает наибольшую цифру числа.
// int MaxNumber(int max)
// {
//     int num1 = max / 10;
//     int num2 = max % 10;
//     if (num1 > num2)
//     {
//         return num1;
//     }
//     else
//     {
//         return num2;
//     }
// }

// int randNumber = new Random().Next(10, 100);
// int newNumber = MaxNumber(randNumber);
// Console.WriteLine($"Максимальное цифра из {randNumber} - это {newNumber}");




// Task 3.
// Напишите программу, которая принимает на вход число и проверяет,
//  кратно ли оно одновременно a и b.
// bool QuadFind(int number, int div1, int div2)
// {
//     if(number % div1 == 0 && number % div2 == 0)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// Console.WriteLine("Введите число для проверки: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число A : ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B : ");
// int numB = Convert.ToInt32(Console.ReadLine());

// bool result = QuadFind(num1, numA, numB);
// Console.WriteLine(result);


//Task 4.
//Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
// bool QuadFind(int num1, int num2)
// {
//     if (num1 == num2 * num2 || num2 == num1 * num1)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(QuadFind(num1, num2));