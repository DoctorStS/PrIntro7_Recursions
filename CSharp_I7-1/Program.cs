/*Задача 1: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Использовать рекурсию, не использовать циклы.*/

int m = 20;
int n = 42;
Console.WriteLine(NaturalNums(m,n));

string NaturalNums (int m, int n)
{
    string result = m.ToString();
    if (m == n) return result;
    return result += " " + NaturalNums(m+1,n).ToString();
}