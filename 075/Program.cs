//75. Написать программу вычисления функции Аккермана - 5*

System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
int A (int m, int n)
{
    if (m == 0) return n + 1;
    else
        if (m > 0 && n == 0) return A(m - 1, 1);
        else
            return A(m - 1, A(m, n - 1));
}
System.Console.WriteLine($"A({m},{n})={A(m,n)}");
