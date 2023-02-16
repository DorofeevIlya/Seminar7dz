// 71. Показать натуральные числа от N до 1, N задано

Random  r = new Random ();
int N = r.Next(1,10);
System.Console.Write($"Задано случайное число {N}");
System.Console.WriteLine();
System.Console.WriteLine();
int i=1;
void Loop(int N, int i)
{
    System.Console.Write($"{N,4}");
    if (i<N) Loop(N-1,i);
}
Loop (N,i);
