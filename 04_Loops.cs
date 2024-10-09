using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region FOR DONGUSU
            //For Döngüsü
            int i;

            for (i = 1; i < 6; i++)
            {
                Console.WriteLine("C# Eğitim Kampı");
            }

            for (i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
            for (i = 3; i <= 50; i += 3)
            {
                Console.WriteLine(i);
            }

            Console.Write("Lütfen Ekrana yazılmasını İstediğiniz Sayıyı Giriniz : ");
            int finishValue = int.Parse(Console.ReadLine());

            for (i = 1; i <= finishValue; i++)
            {
                Console.WriteLine("Yaşasın Cumhuriyet");
            }
            #endregion

            #region FOR Döngüsü ile karar yapıları
            for ( i = 0; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            int totalvalue = 0;

            for ( i = 0; i < 10; i++)
            {
                totalvalue += i;
            }
            Console.WriteLine(totalvalue);

            int totalValue = 0;
            for (i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    totalValue += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("----------");
            Console.WriteLine(totalValue);

            int Count = 0;
            for ( i = 1; i < 50; i++)
            {
                if (i % 7 == 0)
                {
                    Count++;
                }
            }
            Console.WriteLine(Count);

            int bakteri = 1;

            for ( i = 1; i <= 24; i++)
            {
                bakteri *= 2;
                Console.WriteLine(i + ". Saatin Sonunda Oluşan Bakteri Durumu : " + bakteri);
            }
            Console.WriteLine("Toplam Bakteri " + bakteri);


            #endregion

            #region While Döngüsü
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Merhaba Döngüler");
                i++;
            }

            int i = 1;
            while (i <= 10)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            int i = 1;
            int sum = 0;

            while (i <= 10)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine(sum);


            #endregion

            #region Örnek Sınav Sorusu

            //Kalvyeden Girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
            //456
            Console.Write("Sayıyı Giriniz :");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;
            Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            sum = ones + tens + hundreds ;
            Console.WriteLine(sum);

            #endregion

            Console.Read();
        }
    }
}
