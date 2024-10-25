using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //() varsa methottur. mor renkte küp alırlar
            // geriye değer döndüremyen metotlar
            //customer--->listele - ekle - sil - güncelle
            // void geriye değer döndürmeyen metottur

            void customer_list()
            {
                Console.WriteLine("Ali yıldız");
                Console.WriteLine("Ayşe yıldız");
                Console.WriteLine("Hakan Öztürk");
                Console.WriteLine("Merve Çınar");
            }

            customer_list();

            void sum()
            {
                int x = 1;
                int y = 2;
                int z = x + y;
                Console.WriteLine(z);
            }
            sum();




            #endregion

            #region Geriye değer Döndürmeyen String Parametereli Metotlar

            void WriteMethods(string customerNames)
            {
                Console.WriteLine(customerNames);
            }
            WriteMethods("Mehmet Yıldırım");


            void CustomerCard(string name, string surName)
            {
                Console.WriteLine("Müşteri :" + name + " " + surName);
            }
            CustomerCard("Mehmet", "Yıldız");


            #endregion

            #region Geriye değer Döndürmeyen İNT Parametereli Metotlar

            void sum(int number1, int number2, int number3)
            {
                int result = number1 + number2 + number3;
                Console.WriteLine(result);
            }
            sum(4, 5, 6);




            #endregion

            #region Geriye Değer Döndğren Metotlar

            string CustomerName()
            {
                return "Buse Yıldız";
            }
            CustomerName();

            string StudentCard()
            {
                string name = "Ali";
                string surName = "kaya";

                return name + " " + surName;

            }
            Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndğren String Parametreli Metotlar
            string CountryCard(string CountryName, string Capital, string flagColor)
            {
                string cardinfo = CountryName + " " + Capital + " " + flagColor;
                return cardinfo;
            }
            string x, y, z;
            Console.Write("Ülke Adını giriniz: ");
            x = Console.ReadLine();
            Console.Write("başkenti Gİriniz : ");
            y = Console.ReadLine();
            Console.Write("bayrak rengini griiniz :");
            z = Console.ReadLine();

            Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndğren İNT Parametreli Metotlar

            int sum(int number1, int number2)
            {
                int result = number1 + number2;
                return result;
            }
            Console.WriteLine(sum(1, 2));


            int ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    Console.WriteLine(student+"öğrenci sınvaı geçti");
                }
                else
                {
                    Console.WriteLine(student + "öğrenci sınvaı geçemdi");
                }
            }
            Console.WriteLine(ExamResult("ahmet", 63, 76, 45));


            #endregion



            Console.Read();
        }
    }
}
