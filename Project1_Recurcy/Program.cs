// Написать программу, которая выводит числа от 1 до n без использования циклов

  /*
  Реализация через goto (не рекомендуется исп. goto!!!) 
  int i=0;
  int N=20;
  System.Console.Write($"{i,4}");
  Start:
  Console.Write($"{++i,4}");
  if (i<N) goto Start;
*/

// Реализация через рекурсию

void Loop (int i, int N) // i - начальное знач., N - конечное
{
  System.Console.Write($"{i++,4}");
  if (i<N+1)
  {
  Loop(i,N);
  }
}

Loop(1,15);

// Нахождение факториала:

int Fact (int N) // где N - факториал какого числа ищем
{
   if (N>0) return Fact(N-1)*N; // компьютер будет потворять цикл, пока не найдет знакомый факторил (т.е. факториал 0)
                               // после этого , начнет "распутывать" этот клубок
   else if (N<0) return Fact(N+1)*N; 
   else return 1;
}

int Factorial = 5;
System.Console.WriteLine();
System.Console.WriteLine(Fact(Factorial));

// Вывести число Фибоначи по его порядковому номеру

int Fib (int N) // где N - порядковый номер конечного числа Фибоначи
{
  if (N==1) return 0;
  else if (N<1) return -1;
  else if (N==2) return 1;
  else if (N==3) return 1;
  else return Fib(N-1)+Fib(N-2);
}

int Fibonacci = 10;
System.Console.WriteLine(Fib(Fibonacci));

//Возведение в степент

double Power (int a, int b) // где a - число, b - степень
{
  if (b==0) return 1;
  else if (b>0) return Power(a,b-1)*a;
  else return (double) (Power(a,b+1)*1/a) ;
}

int num = 10;
int pow = -3;
System.Console.WriteLine(Power(num,pow));