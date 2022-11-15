// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое цисло M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое цисло N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num1, int num2)
{
    if (num1 == num2) return num1;
    return (num2 + SumNumbers(num1, num2 - 1));
}

int sum = default;
if (m <= n) sum = SumNumbers(m, n);
if (m >= n) sum = SumNumbers(n, m);

Console.WriteLine($"{sum}");

