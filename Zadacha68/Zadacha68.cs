// Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29
int Acc(int n, int m)
{
    if (n == 0) return m + 1;
    else if ((n != 0) && (m == 0)) return Acc(n - 1, 1);
    else return Acc(n - 1, Acc(n, m - 1));
}

Console.WriteLine (Acc(3,2));