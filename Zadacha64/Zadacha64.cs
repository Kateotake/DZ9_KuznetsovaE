﻿//Задача 64: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные 
//числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


string NumbersRec(int M, int N)
{
    if (M <= N) return $"{M} " + NumbersRec(M + 1, N);
    else return String.Empty;
}

Console.WriteLine(NumbersRec(10, 20));
