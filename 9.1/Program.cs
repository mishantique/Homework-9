using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы вошли в калькулятор");
            try
            {
                Console.Write("Введите целое число. X = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число. Y = ");
                int b = Convert.ToInt32(Console.ReadLine());

                int choice;
                Console.Write("Введите код операции: \n\t\t1\t-\tсложение \n\t\t2\t-\tвычитание" +
        "\n\t\t3\t-\tпроизведение \n\t\t4\t-\tчастное\nВаш выбор: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Результат = {0}", a + b);
                }

                else if (choice == 2)
                {
                    Console.WriteLine("Результат = {0}", a - b);
                }

                else if (choice == 3)
                {
                    Console.WriteLine("Результат = {0}", a * b);
                }

                else if (choice == 4)
                {
                    Console.WriteLine("Результат = {0}", (double)a / (double)b);
                }

                else
                {
                    Console.WriteLine("Нет операции с указанным номером.");
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
