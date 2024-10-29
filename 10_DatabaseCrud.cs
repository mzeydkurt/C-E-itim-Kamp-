using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** MENU SİPARİŞ İŞLEM PANELİ *****");
            Console.WriteLine();

            Console.WriteLine("----------------------");

            #region KATEGORİ EKLEME İŞLEMİ
            Console.Write("Eklemek istediğiniz kategori adı : ");
            string categoryName = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data source = ZEYDKURT;initial catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblCategory (categoryName) values (@p1)", connection);
            command.Parameters.AddWithValue("@p1", categoryName);
            command.ExecuteNonQuery();
            connection.Close();
            Console.Write("kategori başarıyla eklendi!");
            #endregion


            #region ÜRÜN EKLEME İŞLEMİ

            string productName;
            decimal productPrice;
            //bool productStatus;

            Console.Write("Ürün Adı: ");
            productName = Console.ReadLine();
            Console.Write("Ürün Fiyatı: ");
            productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source = ZEYDKURT; initial catalog = EgitimKampiDb; integrated security = true");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productStatus", true);
            command.ExecuteNonQuery();
            connection.Close();
            Console.Write("Ürün Eklemesi Başarılı!");


            #endregion

            #region ÜRÜN LİSTELE İŞLEMİ


            SqlConnection connection = new SqlConnection("Data Source = ZEYDKURT; initial catalog = EgitimKampiDb; integrated security = true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from TblProduct", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine();
            }



            #endregion

            #region ÜRÜN SİLME İŞLEMİ
            Console.Write("silinecek ürün id girin : ");
            int productId = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source = ZEYDKURT; initial catalog = EgitimKampiDb; integrated security = true");
            connection.Open();
            SqlCommand command = new SqlCommand("delete from TblProduct where ProductId = @productId", connection);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Silme işlemi yapıldı");


            #endregion

            #region  ÜRÜN GÜNCELLEME İŞLEMİ

            Console.Write("Güncellenecek ürün ID : ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı : ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı : ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source = ZEYDKURT; initial catalog = EgitimKampiDb; integrated security = true");
            connection.Open();
            SqlCommand command = new SqlCommand("update TblProduct set ProductName = @productName,ProductPrice = @productPrice  where ProductId = @productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Güncelleme başarılıdır!");

            #endregion



            Console.Read();


        }
    }
}
