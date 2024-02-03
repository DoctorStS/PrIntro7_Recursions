/*Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.*/

int n = 4;
int m = 1;

/*  f(a,b,0) = a+b
    f(a,0,n+1) = A(a,n)
    f(a,b+1,n+1) = f(A,f(a,b,n+1),n)

    A(0,m) = m+1
    A(n+1,0) = A(n,1)
    A(n+1,m+1) = A(n,A(n+1,m))  */

// int Ackermann0(int n, int m) // WRONG ALGORYTHM
// {
//     while (n != 0)
//     {
//         if (m == 0)
//         {
//             Console.WriteLine($"D - {n}, {m}");
//             m = 1;
//             Console.WriteLine($"B - {n}, {m}");
//         }
//         else
//         {
//             m = Ackermann0(n, m-1);
//             Console.WriteLine($"A - {n}, {m}");
//         }
//         n--;
//         Console.WriteLine($"C - {n}, {m}");
//         return m+1;
//     }
//     return m+1;
// }

int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
        else
            return 0;
    }

Console.WriteLine($"Akkermann({n},{m}) = {Ackermann(n,m)}");