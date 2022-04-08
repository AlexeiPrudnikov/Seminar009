void Multiple3 (int m, int n)
{
    if (m % 3 == 0) Console.Write($"{m} ");
    if (m == n) 
    {
        Console.WriteLine();
        return;
    }
    Multiple3 (m + 1, n);
}
Console.Clear();
Console.WriteLine("==========Задача № 64==========");
Console.WriteLine("Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N");
Multiple3(3, 21);
