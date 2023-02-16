// С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1. Использовать рекурсию.

System.Console.Write("Введите число N: ");
int N= Convert.ToInt32(Console.ReadLine());
long f=0;
long f1=1;
int k=0;
void Fibona44i (long f, int N)
{
    System.Console.Write($" {f} "); 
    f=f1-f;
    f1=f+f1;
    k++;  
    if (k<N) Fibona44i (f,N);    
}
Fibona44i (f,N);
