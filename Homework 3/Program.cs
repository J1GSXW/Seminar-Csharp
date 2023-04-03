//Напишите программу, которая принимает на вход пятизначное
//число и проверяет, является ли оно палиндромом.

// bool Palindrom(int number)
// {
//     int tempNum = number;
//     int invertNum = 0;
//     while (number > 0)
//     {
//         int lastNum = number % 10;
//         invertNum = invertNum * 10 + lastNum;
//         number = number / 10;
//     }
//     if (invertNum == tempNum)
//         return true;
//     else return false;
// }

// Console.WriteLine("Введите любое целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (Palindrom(num) == true)
// Console.WriteLine("Ваше число - палиндром.");
// else 
// Console.WriteLine("Ваше число не палиндром.");




//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

// double Lenght(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
// }
// Console.WriteLine("Введите x1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z1");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите x2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z2");
// int z2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Расстояние между точками {Math.Round(Lenght(x1, y1, z1, x2, y2, z2), 2)}");




//Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
void Cube(int n)
{
    int index = 1;
    while (index <= n)
    {
        Console.WriteLine($"{index} - {Math.Pow(index, 3)}");
        index++;
    }
}
Console.Write("Введите число n: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Cube(num1);