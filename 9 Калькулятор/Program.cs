using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            int op;
            Console.WriteLine("___КАЛЬКУЛЯТОР___");
        Ba:
            try
            {
                Console.Write("Введите первое число: ");
                a = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"- {e.Message}");
                goto Ba;
            }
        Bb:
            try
            { 
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"- {e.Message}");
                goto Bb;
            }
        Bop:
            try
            {
                Console.WriteLine($"Выберите код операции:");
                Console.WriteLine($"1-сложение\t2-вычитание\t3-умножение\t4-деление");
                Console.Write($"Выбраный код операции:");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine($"Результат: {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"Результат: {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"Результат: {a * b}");
                        break;
                    case 4:
                        Console.WriteLine($"Результат: {a / b}");
                        break;
                    default:
                        throw new Exception("Указан неверный код операции!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"- {e.Message}");
                goto Bop;
            }
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
