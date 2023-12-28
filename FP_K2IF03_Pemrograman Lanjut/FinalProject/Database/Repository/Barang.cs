using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace FinalProject.Database.Repository
{
    public class Barang: DatabaseConnection
    {
        public int Id
        {
            get; set;
        }
        public string Nama
        {
            get; set;
        }
        public int Jumlah
        {
            get; set;
        }
        public string Tanggal
        {
            get; set;
        }
        public int KategoriId
        {
            get; set;
        }
        public Barang(string nama)
        {
            Nama = nama;
        }

        public Barang(int id, string nama, int jumlah, string tanggal, int kategori)
        {
            Nama = nama;
            Jumlah = jumlah;
            Id = id;
            Tanggal = tanggal;
            KategoriId = kategori;
        }

        public Barang(int id, string nama)
        {
            Id = id;
            Nama=nama;
        }

        public static Barang Create(string nama, int jumlah, string tanggal, int kategoriId)
        {
            connection.Open();

            string query = "insert into barang (nama, jumlah, tanggal, kategori_id) values (@nama, @jumlah, @tanggal, @kategori)";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@nama", nama);
            command.Parameters.AddWithValue("@jumlah", jumlah);
            command.Parameters.AddWithValue("@tanggal", tanggal);
            command.Parameters.AddWithValue("@kategori", kategoriId);
            command.ExecuteNonQuery();

            string queryFind = "select * from barang order by id desc limit 1";
            SQLiteCommand commandFind = new SQLiteCommand(queryFind, connection);
            SQLiteDataReader barangReader = commandFind.ExecuteReader();

            List<Barang> koleksiBarang = new List<Barang>();

            while (barangReader.Read())
            {
                Barang barangDariDB = new Barang(
                    int.Parse(barangReader["id"].ToString()),
                    barangReader["nama"].ToString(),
                    int.Parse(barangReader["jumlah"].ToString()),
                    barangReader["tanggal"].ToString(),
                    int.Parse(barangReader["kategori_id"].ToString())
                );

                koleksiBarang.Add(barangDariDB);
            }

            connection.Close();

            if(koleksiBarang.Count == 0)
            {
                return null;
            }

            return koleksiBarang[0];
        }
        public static void Update(int id,int hasil)
        {
            connection.Open();
            string query = "Update barang set jumlah=@jumlah where id = @id";
            SQLiteCommand comand = new SQLiteCommand(query, connection);

            comand.Parameters.AddWithValue("@id", id);
            comand.Parameters.AddWithValue("@jumlah", hasil);
            comand.ExecuteNonQuery();
            
            connection.Close();
        }
        public static void Delete(int id)
        {
            connection.Open();
            string query = "delete from barang where id=@id";
            SQLiteCommand comand = new SQLiteCommand(query, connection);

            comand.Parameters.AddWithValue("@id", id);
            comand.ExecuteNonQuery();

            connection.Close();
        }

        public static List<Barang> GetAll() 
        {
            connection.Open();

            string query = "select * from barang";     
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader barangReader = command.ExecuteReader();

            List<Barang> koleksiBarang = new List<Barang>();

            while(barangReader.Read())
            {
                Barang barangDariDB = new Barang(
                    int.Parse(barangReader["id"].ToString()),
                    barangReader["nama"].ToString(),
                    int.Parse(barangReader["jumlah"].ToString()),
                    barangReader["tanggal"].ToString(),
                    int.Parse(barangReader["kategori_id"].ToString())
                ) ;

                koleksiBarang.Add(barangDariDB);
            }

            connection.Close();

            return koleksiBarang;
        }

        public static bool CheckNama(string nama)
        {
            connection.Open();
            string queryFind = "select count(*) as result from barang where nama=@nama";
            SQLiteCommand commandFind = new SQLiteCommand(queryFind, connection);
            commandFind.Parameters.AddWithValue("@nama", nama);
            SQLiteDataReader countReader = commandFind.ExecuteReader();

            bool sudahAda = false;

            while (countReader.Read())
            {
                sudahAda = int.Parse(countReader["result"].ToString()) > 0;
            }

            connection.Close();

            return sudahAda;
        }
    }
}
