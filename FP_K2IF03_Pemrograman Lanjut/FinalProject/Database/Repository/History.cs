using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database.Repository
{
    internal class History: DatabaseConnection
    {
        public int Id
        {
            get; set;
        }
        public int BarangId
        {
            get; set;
        }
        public int NilaiPerubahan
        {
            get; set;
        }
        public string Aksi
        {
            get; set;
        }
        public string Tanggal
        {
            get; set;
        }
        public Barang Barang
        {
            get; set;
        }

        public History(int id, int barangId, int nilaiPerubahan, string aksi, string tanggal, Barang barang)
        {
            Id = id;   
            BarangId = barangId;
            NilaiPerubahan = nilaiPerubahan;
            Aksi = aksi;
            Tanggal = tanggal;
            Barang = barang;
        }

        public static History Create(int barangId, int nilaiPerubahan, string aksi)
        {
            DateTime currentDateTime = DateTime.Now;

            connection.Open();

            string query = "insert into history (barang_id, nilai_perubahan, aksi, tanggal) values (@barangId, @nilaiPerubahan, @aksi, @tanggal)";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@barangId", barangId);
            command.Parameters.AddWithValue("@nilaiPerubahan", nilaiPerubahan);
            command.Parameters.AddWithValue("@aksi", aksi);
            command.Parameters.AddWithValue("@tanggal", currentDateTime.ToString("dd-MMMM-yyyy HH:mm:ss"));
            command.ExecuteNonQuery();

            string queryFind =
                "select h.*, b.id as barang_id, b.nama as barang_nama " +
                "from history h " +
                "join barang b " +
                "on b.id = h.barang_id " +
                "order by h.id desc " +
                "limit 1 ";

            SQLiteCommand commandFind = new SQLiteCommand(queryFind, connection);
            SQLiteDataReader historyReader = commandFind.ExecuteReader();

            List<History> koleksiHistory = new List<History>();

            while (historyReader.Read())
            {
                Barang barang = new Barang(
                    int.Parse(historyReader["barang_id"].ToString()),
                    historyReader["barang_nama"].ToString()
                );
                History barangDariDB = new History(
                    int.Parse(historyReader["id"].ToString()),
                    int.Parse(historyReader["barang_id"].ToString()),
                    int.Parse(historyReader["nilai_perubahan"].ToString()),
                    historyReader["aksi"].ToString(),
                    historyReader["tanggal"].ToString(),
                    barang
                );

                koleksiHistory.Add(barangDariDB);
            }

            connection.Close();

            if (koleksiHistory.Count == 0)
            {
                return null;
            }

            return koleksiHistory[0];
        }

        public static List<History> GetAll()
        {
            connection.Open();

            string queryFind =
                "select h.*, b.id as barang_id, b.nama as barang_nama " +
                "from history h " +
                "left join barang b " +
                "on b.id = h.barang_id " +
                "order by h.id desc ";

            SQLiteCommand commandFind = new SQLiteCommand(queryFind, connection);
            SQLiteDataReader historyReader = commandFind.ExecuteReader();

            List<History> koleksiHistory = new List<History>();

            while (historyReader.Read())
            {
                Barang barang = null;

                if (historyReader["barang_id"].ToString() == "")
                {
                    barang = new Barang("BARANG SUDAH DI HAPUS");
                }
                else
                {
                    barang = new Barang(
                        int.Parse(historyReader["barang_id"].ToString()),
                        historyReader["barang_nama"].ToString()
                    );
                }
                History barangDariDB = new History(
                    int.Parse(historyReader["id"].ToString()),
                    int.Parse(historyReader["barang_id"].ToString()),
                    int.Parse(historyReader["nilai_perubahan"].ToString()),
                    historyReader["aksi"].ToString(),
                    historyReader["tanggal"].ToString(),
                    barang
                );

                koleksiHistory.Add(barangDariDB);
            }

            connection.Close();

            return koleksiHistory;
        }
    }
}

