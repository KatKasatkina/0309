// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

int M = 0; 
int N = 0; 

int.TryParse(Console.ReadLine(), out M);
int.TryParse(Console.ReadLine(), out N);

string PrintNum(int start, int end)
{
    if (start == end) 
        return start.ToString();
    else
    {
    return (start + " " + PrintNum(start+1, end));
}
}

if (M<N) Console.WriteLine(PrintNum(M,N));
else Console.WriteLine($"Неверный ввод!");