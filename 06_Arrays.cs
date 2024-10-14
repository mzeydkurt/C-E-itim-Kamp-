using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            2,4,6,8,10
            sarı,kırmızı,mavi
            DeğişkenTürü[] Diziadı = new Değişkentürü[elemansayısı]

            string[] colors = new string[4];
            colors[0] = "Kırmızı";
            colors[1] = "Sarı";
            colors[2] = "Beyaz";
            colors[3] = "Mavi";
            Console.WriteLine(colors[2]);

            string[] cities = new string[5];
            cities[0] = "Milano";
            cities[1] = "Budapeeşte";
            cities[2] = "Lyon";
            cities[3] = "Kahire";
            cities[4] = "Üsküp";
            Console.WriteLine(cities[4]);

            int[] numbers = new int[10];
            numbers[0] = 50;
            numbers[1] = 48;
            numbers[2] = 698;
            numbers[3] = 24;
            numbers[7] = 748;
            Console.WriteLine(numbers[7]);
            Console.WriteLine(numbers[5]);

            string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            Console.WriteLine(cities[2]);
            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }

            int[] numbers = { 4, 85, 95, 74, 125, 635, 488, 520, 7426, 2365, 1120 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            char[] chars = { 'a', 'b', 'c', '*', '/', '-' };
            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }

            int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            int maksimumNumber = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] > maksimumNumber)
                {
                    maksimumNumber = myArray[i];
                }
            }
            Console.WriteLine(maksimumNumber);

            string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            Console.WriteLine(persons.Length);

            int[] numbers = { 45, 85, 52, 63, 48, 97, 102 };
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int[] numbers = { 45, 85, 52, 63, 48, 97, 102 };
            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            #endregion

            #region Dizi Metotları
            string[] persons = { "ali", "buse", "merve", "ayşegül", "çınar", "kaya" };
            int index = Array.IndexOf(persons, "merve");
            Console.WriteLine(index);

            int[] numbers = { 45, 86, 95, 63, 72, 10, 25, 22, 36 };
            Console.WriteLine("Dizinin En Büyük Elemanı : " + numbers.Max() + " Dizinin en küçük elemanı : " + numbers.Min());

            #endregion
            #region Kullanıcıdan Değer Alma
            string[] cities = new string[5];
            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write($"Lütfen {i + 1}. şehri giriniz :  ");
                cities[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("------------");
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }

            int[] numbers = { 10, 20, 30, 40, 50 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);


            int[] numbers = { 21, 32, 43, 54, 55, 66, 897, 748, 39, 220 };
            Console.WriteLine("Çift Sayılar :");
            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] % 2 == 0) 
                {
                    Console.WriteLine(numbers[i]);
                }
                
            }
            Console.WriteLine("Tek Sayılar :");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }

            }
            #endregion

            Console.Read();
        }
    }
}
