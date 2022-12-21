// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
//double num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
double num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 2 == 0)
{
    Console.Write($"Число {num1} - чётное ");
}
else
{
    Console.Write($"Число {num1} - нечётное ");
}