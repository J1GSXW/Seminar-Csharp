//Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа
//в промежутке от 1 до N.

// void ShowNums(int num)
// {
//     if(num > 1) ShowNums(num - 1);
//     Console.Write(num + " ");
// }

// Console.Write("Введите ваше число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// ShowNums(num);


//Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр.

// int SumOfDigits(int num)
// {
//     if (num != 0) return SumOfDigits(num / 10) + num % 10;
//     else return 0;
// }
// Console.WriteLine(SumOfDigits(1234));


//f(1234) -> f(123) + 4;
//f(123) -> (12) + 3;
//f(12) -> (1) + 2;
//f(1) -> (0) + 1;
//f(0) -> 0; 
//f(1) -> 0 + 1 = 1;
//f(12) -> 1 + 2 = 3; 
//f(123) -> 1 + 2 + 3 = 6;
//f(1234) -> 1 + 2 + 3 + 4 = 10;

//f(1234) -> 0 + 1 + 2 + 3 + 4

//Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

// void ShowNums(int m, int n)
// {
//     if (m > n)
//     {
//         Console.Write(m + " ");
//         ShowNums(m - 1, n);
//     }
//     if (m < n)
//     {
//         ShowNums(m, n - 1);
//         Console.Write(n + " ");
//     }
//     if (m == n)
//     {
//         Console.Write(n + " ");
//     }
// }
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// ShowNums(m,n);


//Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B.

// double MathFunc(int a, int b)
// {
//     if(b > 0) return MathFunc(a, b - 1) * a;

//     else if(b < 0) return MathFunc(a, b +1) / a;

//     else return 1;
// }

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(MathFunc(a,b));