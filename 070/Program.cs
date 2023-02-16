// 70. Показать натуральные числа от 1 до N, N задано

System.Console.Write("Введите число N: ");
int N= Convert.ToInt32(Console.ReadLine());
int i=1;
void Loop(int i, int N)
{
    System.Console.Write($"{i,4}");
    if (i<N) Loop(i+1,N);
}
Loop (i,N);
