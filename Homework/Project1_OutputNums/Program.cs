﻿// 71. Показать натуральные числа от 1 до N, N задано
namespace ConsoleApp1;
class Program1
{
  static void Main()
  {
    /* компилятор вечно ругался: "только одна единица компиляции может содержать инструкции верхнего уровня".
    Пришлось как-то выкручиваться, в чем проблема не до конца понял.*/

    Console.WriteLine("Программа выводит числа от 1 до N");
    System.Console.Write("Задайте N: "); // по условию N надо задать 
    try
    {
      int N = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      System.Console.WriteLine("Введите целое число");
    }
  }
}