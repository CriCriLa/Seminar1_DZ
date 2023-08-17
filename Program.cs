// Задача 2. Написать программу, которая на вход принимает 
// два числа и выдает какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());


if (num1>num2)
{
    Console.WriteLine("min = " + num2);
    Console.WriteLine("max = " + num1);
}
else
{
    Console.WriteLine("min = " + num1);
    Console.WriteLine("max = " + num2);
}
