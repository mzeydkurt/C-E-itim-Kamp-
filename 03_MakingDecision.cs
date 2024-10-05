using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF ELSE


            Console.Write("Lütfen şifreyi Giriniz : ");
            string password;
            password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.WriteLine("Şifre Doğru");
            }
            else
            {
                Console.WriteLine("Şifre Yanlış");
            }

            string capital, country;
            Console.Write("Başkenti Giriniz :");
            capital = Console.ReadLine();

            Console.Write("Ülkeyi Giriniz : ");
            country = Console.ReadLine();

            if (capital == "ankara" & country == "turkiye")
            {
                Console.WriteLine("Veriler Doğrulandı");

            }
            else
            {
                Console.WriteLine("hatalı veri");
            }

            int sayi;

            Console.Write("Sayıyı Giriniz ;");
            sayi = int.Parse(Console.ReadLine());
            if (sayi == 5)
            {
                Console.WriteLine("Sayı Doğru");
            }
            else
            {
                Console.WriteLine("Sayı hatalı");
            }

            int exam1, exam2, exam3, average;
            string result = "";

            Console.Write("1.Sınavı Giriniz ;");
            exam1 = int.Parse(Console.ReadLine());

            Console.Write("2.Sınavı Giriniz ;");
            exam2 = int.Parse(Console.ReadLine());

            Console.Write("3.Sınavı Giriniz ;");
            exam3 = int.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Sınavların Ortalaması : " + average);

            if (average > 0 & average <= 50)
            {
                result = "Sonuç Vasat";
            }
            if (average > 50 & average <= 70)
            {
                result = "Sonuç Orta";
            }
            if (average > 70 & average <= 84)
            {
                result = "Sonuç İyi";
            }
            if (average > 84)
            {
                result = "Sonuç Çok İyi";
            }

            Console.WriteLine(result);

            string city;
            Console.Write("Lütfen Şehir Girişi Yapınız : ");
            city = Console.ReadLine();

            if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            {
                Console.WriteLine("Şehirler Doğru");
            }
            else
            {
                Console.WriteLine("Şehirler Yanlış");
            }

            string userName;

            Console.Write("lütfen kullanıcı adınızı giriniz : ");
            userName = Console.ReadLine();

            if (userName != "admin")
            {
                Console.WriteLine("Bu Kullanıcı Adı Kabul Edilemez!");
            }
            else
            {
                Console.WriteLine("Hoşgeldiniz");
            }


            #endregion

            #region Mod İşlemleri

            int number;
            number = 26;
            int result = number % 5;
            Console.WriteLine(result);

            Console.Write("Lütfen 1. Sayıyı giriniz : ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. Sayıyı giriniz : ");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 % number2;

            Console.WriteLine("Birinci sayının ikinci sayıya bölümünden kalan  : " + result);

            Console.Write("Lütfen sayıyı Giriniz : ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Sayı Çifttir!");
            }
            else
            {
                Console.WriteLine("Sayı Tektir.");

            }
            #endregion

            #region CHAR İLE KARAR YAPILARI
            char harf;

            Console.Write("Tuttuğunuz Takımın İlk Harfini Giriniz : ");
            harf = char.Parse(Console.ReadLine());

            if (harf == 'g' | harf == 'G')
            {
                Console.WriteLine("GALATASARAY");
            }
            else if (harf == 'f' | harf == 'F')
            {
                Console.WriteLine("fenerbahçe");
            }
            else if (harf == 'b' | harf == 'B')
            {
                Console.WriteLine("BEŞİKTAŞ");
            }
            else
            {
                Console.WriteLine("Yanlış harf Girdiniz");
            }




            #endregion

            #region Örnek Proje Uygulaması

            Console.WriteLine("----- C# EĞİTİM KAMPI RESTORAN -----");
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine("1 - Ana Yemekler ");
            Console.WriteLine("2 - Çorbalar ");
            Console.WriteLine("3 - Pizzalar ");
            Console.WriteLine("4 - İçecekler ");
            Console.WriteLine("5 - Tatlılar ");
            Console.WriteLine("------------------");
            string menuItem;
            Console.WriteLine();

            Console.Write("Lütfen Deteyını Görmek İstediğiniz Menü Seçimini Yapın ! : ");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("--------ANA YEMEKLER----------");
                Console.WriteLine();
                Console.WriteLine("1-Soslu tavuk");
                Console.WriteLine("2-Kızartma tabağı");
                Console.WriteLine("3-Fasulye Pilav");
                Console.WriteLine("4-Fırında Somon");
                Console.WriteLine("5-Patlıcan Musakka");
                Console.WriteLine("--------ANA YEMEKLER----------");
            }
            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("--------Çorbalar----------");
                Console.WriteLine();
                Console.WriteLine("1-Mercimek");
                Console.WriteLine("2-Ezogelin");
                Console.WriteLine("--------Çorbalar----------");
            }
            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("--------Pizzalar----------");
                Console.WriteLine();
                Console.WriteLine("1-Akdeniz");
                Console.WriteLine("2-margeritha");
                Console.WriteLine("3-Tavuklu");
                Console.WriteLine("--------Pizzalar----------");
            }
            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("--------İçecekler----------");
                Console.WriteLine();
                Console.WriteLine("1-Kola");
                Console.WriteLine("2-Ayran");
                Console.WriteLine("3-Su");
                Console.WriteLine("--------İçecekler----------");
            }
            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("--------Tatlılar----------");
                Console.WriteLine();
                Console.WriteLine("1-Triliçe");
                Console.WriteLine("2-Kazandibi");
                Console.WriteLine("3-Sütlaç");
                Console.WriteLine("--------Tatlılar----------");
            }
            #endregion

            #region SWİTCH CASE
            //Console.Write("İstediğinizi Ayın Numrasını Giriniz : ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //        default: Console.Write("Yanlış Seçim"); break;
            //}



            #endregion

            #region Switch Case Hesap Makinesi

            int number1, number2, result;
            char symbol;

            Console.Write("1. SAYIYI GİRİNİZ : ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2. SAYIYI GİRİNİZ : ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Yapmak istediğiniz İşlemin Sembolünü Giriniz : ");
            symbol = char.Parse(Console.ReadLine());


            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam : " + result);
                    break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Çıkarma : " + result);
                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpma : " + result);
                    break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölme : " + result);
                    break;
                default :
                    Console.WriteLine("Yanlış Seçim Yaptınız!");
                    break;
                    
            }

            #endregion
            Console.Read();
        }
    }
}
