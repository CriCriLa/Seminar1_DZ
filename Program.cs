// // Задача 2. Написать программу, которая на вход принимает 
// // два числа и выдает какое число большее, а какое меньшее.

// Console.Clear();
// Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());


// if (num1>num2)
// {
//     Console.WriteLine("min = " + num2);
//     Console.WriteLine("max = " + num1);
// }
// else
// {
//     Console.WriteLine("min = " + num1);
//     Console.WriteLine("max = " + num2);
// }

// Задача 4. Напишите программу, которая принимает на вход три числа 
// и выдает максимальное из этих чисел. 

// Console.Clear();
// Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1>num2)
// {
//     if (num1>num3)
//     {
//         Console.WriteLine("Максимальное число: " + num1);
//     }
//     else
//     {
//         if (num2>num3)
//         {
//             Console.WriteLine("Максимальное число: " + num2);
//         }
//         else
//         {
//             Console.WriteLine("Максимальное число: " + num3);
//         }
//     }
// }
// else if (num2>num3)
// {
//     Console.WriteLine("Максимальное число: " + num2);
// }
// else 
// {
//     Console.WriteLine("Максимальное число: " + num3);
// }
// Задача 6: Напишите программу, которая на вход принимает 
// число и выдает, является ли число четным.
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine("Да");
}