int Akkerman (int n, int m)
{
    if (n == 0) return m + 1;
    else
    {
        if ((m == 0) && (n > 0)) 
            return Akkerman(n - 1, 1);
        else
        {
            return Akkerman(n - 1, Akkerman(n, m-1));
        }
    }
}
Console.Clear();
Console.WriteLine("==========Задача № 68==========");
Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n");
Console.WriteLine (Akkerman(3, 2));
