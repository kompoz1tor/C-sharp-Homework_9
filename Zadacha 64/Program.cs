/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N, кратные трём.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""
*/
Console.WriteLine("Программа, которая выведет все натуральные числа в промежутке от M до N, кратные трём.");
Console.WriteLine("Введите М");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());

Recursion(m, n);
void Recursion(int m, int n)
{
    if (m > n)
    {
        return;
    }
    if (m % 3 == 0 && m > 0)
    {
        Console.Write(m + "\t");
    }
    m++;
    Recursion(m, n);
}