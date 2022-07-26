/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Программа, которая которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine("Введите М");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());


Recursion(m + 1, n - 1);
void Recursion(int m, int n, int sum = 0)
{
    if(m > n)
    {
        Console.WriteLine("Сумма натуральных элементов в промежутке от M до N: " + sum);
        return;
    }
    sum = sum + m;
    m++;
    Recursion(m, n, sum);
}
/*
int sum = 0;
while (m < n)
{
    sum = sum + m;
    m++;
}
Console.Write (sum);
*/
