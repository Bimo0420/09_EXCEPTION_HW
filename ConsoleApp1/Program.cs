using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Введите целое число:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите целое число:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите код операции: \n\t 1 - сложение \n\t 2 - вычитание \n\t 3 - произведение \n\t 4 - частное");
            double c = Convert.ToDouble(Console.ReadLine());
                            
                if (c == 1)
                {
                    Console.WriteLine("Ответ: {0}", a + b);
                }
                else if (c == 2)
                {
                    Console.WriteLine("Ответ: {0}", a - b);
                }
                else if (c == 3)
                {
                    Console.WriteLine("Ответ: {0}", a * b);
                }
                else if (c == 4)
                {
                    Console.WriteLine("Ответ: {0}", a / b);
                    //try
                    //{
                    //    Console.WriteLine("Ответ: {0}", a / b);
                    //}
                    //catch (DivideByZeroException) when (b == 0)
                    //{
                    //    Console.WriteLine("Деление на ноль");
                    //}

                }
                else
                {
                    Console.WriteLine("Нет операции с указанным номером");
                }

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
