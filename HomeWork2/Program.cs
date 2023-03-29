//Task 1.
//Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// int SecondNum(int number)
// {
//     int num1 = number / 10;
//     int num2 = num1 % 10;
//     return num2;
// }
// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SecondNum(num));


//Task 2. Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.
// int ThirdNum(int number)
// {
//     if(number < 100)
//     {
//         return number;
//     }
//     else
//     {
//     while (number > 1000)
//     {
//         number = number / 10 ;
//     }
//     return number % 10;
//     }
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number == ThirdNum(number))
// {
//     Console.WriteLine($"В числе {number} отсутствует третья цифра");
// }
// else
// {
//     Console.WriteLine(ThirdNum(number));
// }

//Task 3. Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// bool WeekendFind(int date)
// {
//     if (date >= 1 && date <= 5 || date > 8)
//     {
//         return false;
//     }
//     else
//     {
//         return true;
//     }
// }

// Console.Write("Введите число: ");
// int weekDay = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(WeekendFind(weekDay));