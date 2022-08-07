// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120, M = 4; N = 8. -> 30

int M = 0; 
int N = 0; 

int.TryParse(Console.ReadLine(), out M);
int.TryParse(Console.ReadLine(), out N);
//int[] array = new int [N-M+1];

int Sum(int a, int b)
{
    int sum = 0;
for (int i = a; i <= b; i++)
{
sum = sum+i;

   }
   return sum;
}

if (M<N) Console.WriteLine(Sum(M,N));
else Console.WriteLine($"Неверный ввод!");
