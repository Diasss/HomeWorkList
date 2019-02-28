using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkList
{
    class Program
    {
        static void Main(string[] args)
        {
            task5();
            
        }
        static void Task1()
        {
            List<int> num = new List<int>();
            Random rnd = new Random();
            int kolvo = Int16.Parse(Console.ReadLine());
            for (int i = 0; i < kolvo; i++)
            {
                num.Add(rnd.Next(1, 50));
                Console.Write("{0} ", num[i]);
            }
            Console.WriteLine("\nТеперь отсортируем\n");
            num.Sort();
            for (int i = 0; i < kolvo; i++)
            {
                Console.Write("{0} ", num[i]);
            }
            Console.WriteLine("Вторым максимальным значением в коллекции является - {0}", num[kolvo-1]);
            Console.WriteLine("Индекс этого значение - {0}", (kolvo-1));
        }
        static void Task2()
        {
            List<int> num = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
            {
                num.Add(rnd.Next(1, 50));
                Console.Write("{0} ", num[i]);
            }
            Console.WriteLine("\nУдалим все нечетные элементы\n");
            for (int i = 0; i < 12; i++)
            {
                if (i % 2 != 0)
                {
                    num.RemoveAt(i);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} ", num[i]);
            }
        }
        static void task3()
        {
            List<double> num = new List<double>();
            Random rnd = new Random();
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                num.Add(rnd.NextDouble());
                sum += num[i];
                Console.WriteLine("{0}){1}", i+1, num[i]);
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Среднее Арифмитическое: {0}", sum/10);
            Console.WriteLine("\n\n");
            for (int i = 0; i < 10; i++)
            {
                if (num[i] > sum / 10)
                {
                    Console.WriteLine("{0}){1}", i+1, num[i]);
                }
            }
        }
        static void task5()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            if ((string)s2.Reverse()==s1)
            {
                Console.WriteLine("Строка s2 Обратна строке s1");
            }
            else
            {
                Console.WriteLine("Строки не обратны друг другу");
            }
            //int k = 0;
            //if (s1.Length != s2.Length)
            //{
            //    Console.WriteLine("s1 не является обратной строкой s2");
            //}
            //else
            //{
            //    for (int i = 0; i < s1.Length; i++)
            //    {
            //        if (s1[i] == s2[s2.Length - i])
            //        {
            //            k++;
            //        }
            //        else
            //        {
            //            throw new Exception("Строки не являются обратными!");
            //        }
            //    }
            //    if (k == s1.Length)
            //    {
            //        Console.WriteLine("Строка s2 Обратна строке s1");
            //    }
            //    else
            //    {
            //        throw new Exception("строки не являются обратными!");
            //    }
            //}
            
        }

    }
}
