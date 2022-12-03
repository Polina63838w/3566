// Console.WriteLine("Hello, World!");

//напишите программу, которая на вход принимает число а на выход его квадрат
//Например
//4->16
//-3->9
//-7->49
// Console.Write("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
// int result = num * num;
// Console.WriteLine ($"Квадрат числа равен {result} ");

        //Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
        //a = 25, b = 5 -> да
        //a = 2, b = 10 -> нет
        //a = 9, b = -3 -> да
        //a = -3 b = 9 -> нет
        // Console.WriteLine("Введите a: ");
        // int num1 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Введите b: ");
        //  int num2 = Convert.ToInt32(Console.ReadLine());
        // if (num2 * num2 == num1 )
        // {
        //     Console.WriteLine("да");
        // }
        // else
        // {
        //     Console.WriteLine("нет");
        // }


//     Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// Console.WriteLine("Введите a: ");
//         int num1 = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Введите b: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 < num2)
// {
//     Console.WriteLine(num2);
// }
// else if(num1 > num2)
// {
//     Console.WriteLine(num1);
// }


//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите a: ");
//          int num1 = Convert.ToInt32(Console.ReadLine());
//       Console.WriteLine("Введите b: ");
//  int num2 = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите c: ");
//          int num3 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2 && num1 > num3)
// {
//     Console.WriteLine(num1);
// }
// else if (num2 > num1 && num2 > num3)
// {
//     Console.WriteLine(num2);
// }
// else 
// {
//     Console.WriteLine(num3);
// }

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

//  Console.WriteLine("Введите число: ");
//   int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1%2==0)
// {
//  Console.WriteLine("да");
// }
// else 
// {
// Console.WriteLine("нет");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Write number 1: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Write number 2: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }