using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programsss
{
    internal class Program
    {
        public static int a;
        static void Main()
        {
            int c, chislо;
            int num;


            do
            {
                Console.WriteLine("Выберите программу");
                Console.WriteLine("1-Угадай число.");
                Console.WriteLine("2-Таблица умножения.");
                Console.WriteLine("3-Вывод делителей числа.");
                Console.WriteLine("4-Закрыть программу.");

                a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {

                    case 1:


                        Console.WriteLine("Угадайте число от 0 до 100");
                        Random random = new Random();
                        chislо = random.Next(0, 100);
                        do
                        {
                            Console.WriteLine("Ваш вариант:");
                                c = Convert.ToInt32(Console.ReadLine());
                            if (c < chislо)
                                Console.WriteLine("Число больше");
                            if (c > chislо)
                                Console.WriteLine("Число меньше");
                        } while (c != chislо);
                        Console.WriteLine("Правильние число");
                        break;
                    case 2:
                        for (int i = 1; i <= 9; i++)
                        {
                            for (int f = 1; f <= 9; f++)
                            {
                                Console.Write(i * f + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Введите число:");
                        num = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= num; i++)
                        {
                            if (num % i == 0)
                            {
                                Console.WriteLine(i);
                                break;


                    case 4:
                                    Console.WriteLine();
                                    break;
                                default:
                                    Console.WriteLine("Такой программы нет Выберите программу из списка ");
                                    break;

                                }

                            } while (a != 4) ;
                            Console.WriteLine("Пока ");
                        }
      
