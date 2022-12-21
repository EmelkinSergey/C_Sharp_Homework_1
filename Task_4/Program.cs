// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите целое положительное число: "); 
double N = Convert.ToInt32(Console.ReadLine());

if (N % 2 == 0)
{
    double A = 2;
        while (A < N + 2)
        {
            Console.Write( A + "," );
            A += 2;
        }
}
else
{
    double A = 2;
        while (A < N + 1)
        {
            Console.Write(A + ",");
            A += 2;
        }
}

if (N < 2)
{
    Console.Write("Чётных чисел нет");
}