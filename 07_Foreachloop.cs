using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreachloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach Döngüsü


            string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            foreach (string x in cities)
            {
                Console.WriteLine(x);

            }

            int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }

            }

            int total = 0;
            foreach (int i in numbers)
            {
                total += i;
            }
            Console.WriteLine(total);

            List<int> numbers = new List<int>()
            {
            1,2, 3, 4,5,8
            };

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            string word = "Merhaba!";
            foreach (char s in word)
            {
                Console.WriteLine(s);
            }





            #endregion


            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulamsı");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var :  ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            // öğrenci isim ve ortalamalrını saklayacak dizliler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz :");
                studentNames[i] = Console.ReadLine();

                double total_ExamResult = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    total_ExamResult += value;
                }
                Console.WriteLine();
                studentExamAvg[i] = total_ExamResult / 3;
            }
            //sınav ortalamalı
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortlaması : {studentExamAvg[i]}");
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} Adlı öğrenci Dersi Geçmiştir!!!!");
                }
                else 
                {
                    Console.WriteLine($"{studentNames[i]} Adlı öğrenci Dersi Kaldı!!!!");
                }
                Console.WriteLine("-----------------------") ;
            }




            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("***** C# Eğitim Kampı Sınav Uygulamsı");
            #endregion
            Console.Read();

        }
    }
}
