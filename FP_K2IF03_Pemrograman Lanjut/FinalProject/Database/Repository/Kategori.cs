using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database.Repository
{
    internal class Kategori: DatabaseConnection
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public Kategori(int id, string nama) {
           Id = id;
           Nama = nama;
        }


        public static List<Kategori> GetAll() {
            connection.Open();

            string query = "select * from kategori";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader barangReader = command.ExecuteReader();

            List<Kategori> koleksiKategori = new List<Kategori>();

            while (barangReader.Read())
            {
                Kategori kategoriDariDB = new Kategori(
                    Int32.Parse(barangReader["id"].ToString()),
                    barangReader["nama"].ToString()
                );

                koleksiKategori.Add(kategoriDariDB);
            }

            connection.Close();

            return koleksiKategori;
        }

        public static Kategori FindById(int id)
        {
            connection.Open();

            string query = "select * from barang where id=@id limi 1";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            SQLiteDataReader kategoriReader = command.ExecuteReader();

            List<Kategori> koleksiKategori = new List<Kategori>();

            while (kategoriReader.Read())
            {
                Kategori kategoriDariDB = new Kategori(
                    Int32.Parse(kategoriReader["id"].ToString()),
                    kategoriReader["nama"].ToString()
                );

                koleksiKategori.Add(kategoriDariDB);
            }

            connection.Close();

            if(koleksiKategori.Count == 0)
            {
                return null;
            }

            return koleksiKategori[0];
        }
    }
}
