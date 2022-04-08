int SummBeween (int m, int n)
{
    int summ  = m;
    if (m < n) 
    {
        summ += SummBeween(m + 1, n);
    }
    return summ;
}
Console.Clear();
Console.WriteLine("==========Задача № 66==========");
Console.WriteLine("Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N");
Console.WriteLine (SummBeween(4, 8));
