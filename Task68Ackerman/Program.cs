// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int m= 0; 
int n = 0; 

int.TryParse(Console.ReadLine(), out m);
int.TryParse(Console.ReadLine(), out n);

int Ackerman(int a, int b)
{
  if (a == 0) return b + 1;
  else if (b == 0) return Ackerman(a - 1, 1);
  else return Ackerman(a - 1, Ackerman(a, b - 1));
}

if (m > 0 && n > 0) Console.WriteLine(Ackerman(m,n));
else Console.WriteLine($"Неверный ввод!");