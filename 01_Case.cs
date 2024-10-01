using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DOUBLE degiskenler
            ////double number;
            ////number = 4.85;  
            ////Console.WriteLine(number);

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("***** Fiyat Listesi * ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı :" + applePrice + " TL ");
            //Console.WriteLine("---- Portakal Birim Fiyatı :" + orangePrice + " TL ");
            //Console.WriteLine("---- Çilek Birim Fiyatı :" + strawberryPrice + " TL ");
            //Console.WriteLine("---- Patates Birim Fiyatı :" + potatoPrice + " TL ");
            //Console.WriteLine("---- Domates Birim Fiyatı :" + tomatoPrice + " TL " );

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram , strawberryGram, potatoGram , tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice,
            //    orangeTotalPrice = orangeGram * orangePrice,
            //    strawberryTotalPrice = strawberryGram * strawberryPrice,
            //    potatoTotalPrice = potatoGram * potatoPrice,
            //    tomatoTotalPrice = tomatoGram * tomatoPrice;

            ////Console.WriteLine("Elmanın Toplam Fiyatı : " + appleTotalPrice + " ₺");
            ////Console.WriteLine("Portakalın Toplam Fiyatı : " + orangeTotalPrice + " ₺");

            //Console.WriteLine("Alınan Ürün : Elma - " + " Birim Fiyat : " + applePrice + " - Gramaj : " + appleGram + " - Toplam Fiyat : " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün : Portakal - " + " Birim Fiyat : " + orangePrice + " - Gramaj : " + orangeGram + " - Toplam Fiyat : " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün : Çilek - " + " Birim Fiyat : " + strawberryPrice + " - Gramaj : " + strawberryGram + " - Toplam Fiyat : " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün : Patates " + " Birim Fiyat : " + potatoPrice + " - Gramaj : " + potatoGram + " - Toplam Fiyat : " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün : Domates - " + " Birim Fiyat : " + tomatoPrice + " - Gramaj : " + tomatoGram + " - Toplam Fiyat : " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice+potatoTotalPrice+tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar : " + shoppingTotalPrice + " ₺");
            #endregion


            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);



            #endregion

            #region KLAVYEDEN VERİ GİRİŞLERİ STRİNG DEĞİŞKENŞLER

            //Console.WriteLine("***** CS Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname , passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı : ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu SoyAdı : ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu İlçesi : ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Adı : ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş : ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu ID : ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("---------------");
            //Console.WriteLine("Yolcu ID :  "+ passengerIdentityNumber +"Ad Soyad : "+ passengerName +" "+ passengerSurname + " " + passengerDistrict + "/"+ passengerCity + " " + passengerAge);



            #endregion

            #region KLAVYEDEN TAM SAYI GİRİŞLERİ VE DÖNÜŞÜMLER
            Console.OutputEncoding = Encoding.UTF8;
            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount , computerCount , chairCount , tvCount ;

            //Console.Write("Lütfen Aldığınız ayakkabı sayısını giriniz :");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisiyar Sayısını Giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("lütfen Aldığınız sandalye sayısını giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldıpınız TV sayısını giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + tvCount * tvPrice + chairCount * chairPrice;  

            //Console.WriteLine("Toplam Ödemeniz Gerek Tutar : " + totalPrice + " ₺");


            #endregion

            #region KLAVYEDEN DOUBLE SAYI GİRİŞ VE DÖNÜŞÜMLERİ

            //double exam1 ,exam2 , exam3 ,result ;

            //Console.Write("Lütfen 1. sınav Notunu Giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav Notunu Giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav Notunu Giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız : " + result);

            #endregion

            #region KLAVYEDEN CHAR GİRİŞ VE DEĞİŞKENLERİ

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz : ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet : " + gender);



            #endregion



            Console.Read();
        }
    }
}
