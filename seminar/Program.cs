/*TASK1
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void Natural (int m, int n)
{
    if(m > n) 
    { 
        int count = n;
        n = m;
        m = count;
    }
    if(n != m) Natural(m, n-1);
    Console.Write(n +" ");
    

}
Console.Write("Please, enter number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter number N: ");
int N = Convert.ToInt32(Console.ReadLine());
Natural(M, N);*/

/*TASK2
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
void SumNum (int m, int n, int sum)
{
    sum += n;
    if(n <= m)
    {
        Console.Write($"The sum of natural elements is {sum}");
        return;
    }  
    SumNum(m, n -1, sum);    
   
}

Console.Write("Please, enter number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter number N: ");
int N = Convert.ToInt32(Console.ReadLine());
SumNum(M, N, 0);*/

/*TASK2
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

int Akkerman (int m, int n)
{
    if(m == 0) 
    {
        return n +1;
    }
    else if( m > 0 && n == 0) 
    {
        return Akkerman (m -1, 1);
    }
    else //if(m > 0 && n > 0) 
    {
        return Akkerman(m -1, Akkerman(m, n-1));
    }
} 
Console.Write("Please, enter number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter number N: ");
int N = Convert.ToInt32(Console.ReadLine());
int FunctionAk = Akkerman(M, N);
Console.Write($"Functoin Akkerman is (M, N) = {FunctionAk}"); */
