// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write($"Число {num1} больше числа {num2}");
}
if (num1 == num2)
{
    Console.Write($"Число {num1} равно числу {num2}");
}
if (num1 < num2)
{
     Console.Write($"Число {num1}  меньше числа {num2}");
}