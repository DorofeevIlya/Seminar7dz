// 74. Найти сумму цифр числа

System.Console.Write("Введите число N: ");
int N= Convert.ToInt32(Console.ReadLine());
int d=0;
int s=0;
int Ostatok (int N)
{
        s=d+s;
        d=N%10;
        if (N!=0) return Ostatok (N/10);
            else return s;
}
Ostatok (N);
System.Console.WriteLine($"Сумма цифр числа {N} = {s}");