//Task 1. Задайте значение n. Напишите программу,
// которая выведет все натуральные числа в промежутке от n до 1.
// Выполнить с помощью рекурсии.

// void Shownums(int num)
// {
//     Console.Write(num + " ");
//     if(num > 1) Shownums(num - 1);
// }

// Console.Write("Введите ваше число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Shownums(num);

//Task 2. Задайте значения m и n.
// Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от m до n.

// int ShowSumnumbers(int m, int n)
// {
//     if (m == n) return m;
//     else if (m < n) return n + ShowSumnumbers(m, n - 1);
//     else return n + ShowSumnumbers(m, n + 1);
// }

// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(ShowSumnumbers(m,n));


//Task 3. Напишите программу вычисления функции 
//Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

// int Akkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (m != 0 && n == 0) return Akkerman(m - 1, 1);
//     else return Akkerman(m-1, Akkerman(m,n-1));
// }

// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(Akkerman(m,n));

