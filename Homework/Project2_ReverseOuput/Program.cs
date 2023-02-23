// 71. Показать натуральные числа от 1 до N, N задано
namespace ConsoleApp2;
class Program2
{
  static void Main()
  {
    /* компилятор вечно ругался: "только одна единица компиляции может содержать инструкции верхнего уровня".
    Пришлось как-то выкручиваться, в чем проблема не до конца понял.*/

    Console.WriteLine("Программа выводит числа от N до 1");
    System.Console.Write("Задайте N. "); // по условию N надо задать 
    int N = InputN();
    int i = 1;
    System.Console.Write($"{N}  ");
    OutputNto1(N,i);



    int InputN()
    {
      int N = -1;
      do
      {
        System.Console.WriteLine("Введите натуральное число:");
      try
      {
        N = Convert.ToInt32(Console.ReadLine());
      }
      catch
      {
        System.Console.WriteLine("Ошибка. Введите натуральное число");
      }
      } while (N<1);
      return N;
    }

    void OutputNto1(int N, int i)
    {
      System.Console.Write($"{--N}  ");
      if (i < N)
        OutputNto1(N, i);
    }

/* остальные ДЗ в другой папке (Homework7). Тут компилятор бесится
*/ 
  }
}