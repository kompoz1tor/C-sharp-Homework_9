/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("Программа вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
Console.WriteLine("------------------------------------------------------------------------------------------------");
Console.WriteLine("Введите М");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());
Accerman(m,n);

int Accerman (int m , int n)
{
    if ( m < 0 && n < 0) return 1;
    else
    if (m == 0)
    {
        return n + 1;
    }
    else
    if (m > 0 && n == 0)
    {
        return Accerman(m - 1, 1);
    }
    else
    if (m > 0 && n > 0)
    {
        return Accerman(m-1, Accerman(m, n - 1));
     }
    Console.Write(Accerman(m,n));
}
