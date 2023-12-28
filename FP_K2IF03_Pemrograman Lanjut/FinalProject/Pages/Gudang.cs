using FinalProject.Database.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Gudang : Form
    {
        List<Barang> KoleksiBarang = new List<Barang>();
        List<History> KoleksiLog = new List<History>();
        List<Kategori> KoleksiKategori = new List<Kategori>();
        public Gudang()
        {
            InitializeComponent();
            ListView();

            // otomatis ngeload kategori, barang, dan logs
            // dari database ketika page gudang ke load
            ReloadKategori();
            ReloadBarang();
            ReloadHistory();
        }

        private void ReloadKategori()
        {
            // load kategori dari database
            KoleksiKategori = Kategori.GetAll();


            // semua kategori yang sudah terload,
            // di render ke dalam combobox kategori
            foreach(Kategori kategori in KoleksiKategori)
            {
                CBPilihan.Items.Add(kategori.Nama);
            }
        }

        private void ReloadBarang()
        {
            KoleksiBarang = Barang.GetAll();

            LstData.Items.Clear();
            ComBoxRestock.Items.Clear();
            ComBoxKeluar.Items.Clear();

            foreach (var barang in KoleksiBarang)
            {
                var item = new ListViewItem(barang.Id.ToString());
                item.SubItems.Add(barang.Nama);
                item.SubItems.Add(barang.Jumlah.ToString());
                item.SubItems.Add(barang.KategoriId.ToString());
                LstData.Items.Add(item);
                ComBoxRestock.Items.Add(barang.Nama);
                ComBoxKeluar.Items.Add(barang.Nama);
            }
        }

        private void ReloadHistory()
        {
            KoleksiLog = History.GetAll();

            LstHistory.Items.Clear();
  

            foreach (var history in KoleksiLog)
            {
                var item = new ListViewItem(history.Id.ToString());
                item.SubItems.Add(history.Barang.Nama);
                item.SubItems.Add(history.NilaiPerubahan.ToString());
                item.SubItems.Add(history.Tanggal);
                item.SubItems.Add(history.Aksi);

                LstHistory.Items.Add(item);
            }
        }

        private void ListView()
        {
            LstData.View = View.Details;
            LstData.FullRowSelect = true;
            LstData.GridLines = true;

            LstData.Columns.Add("No.", 30, HorizontalAlignment.Center);
            LstData.Columns.Add("Nama Barang", 150, HorizontalAlignment.Center);
            LstData.Columns.Add("Jumlah", 100, HorizontalAlignment.Center);
            LstData.Columns.Add("Kategori Barang", 100, HorizontalAlignment.Center);

            LstHistory.View = View.Details;
            LstHistory.FullRowSelect = true;
            LstHistory.GridLines = true;
            
            LstHistory.Columns.Add("No.", 30, HorizontalAlignment.Center);
            LstHistory.Columns.Add("Nama Barang", 150, HorizontalAlignment.Center);
            LstHistory.Columns.Add("Jumlah", 100, HorizontalAlignment.Center);
            LstHistory.Columns.Add("Tanggal", 180, HorizontalAlignment.Center);
            LstHistory.Columns.Add("Keterangan", 100, HorizontalAlignment.Center);
            
        }

        private void ClearBaru_Click(object sender, EventArgs e)
        {
            BarangBaru.Clear();
            JumlahBaru.Clear();
        }

        private void ClearPenambahan_Click(object sender, EventArgs e)
        {
            JumlahPenambahan.Clear();
        }

        private void ClearPengambilan_Click(object sender, EventArgs e)
        { 
            JumlahPengambilan.Clear();
        }
        private bool OnlyNum(KeyPressEventArgs e)
        {
            var vld = "0123456789";

            if (!(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                if (vld.IndexOf(e.KeyChar) < 0)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public void BtnBaru_Click(object sender, EventArgs e)
        {
            if (BarangBaru.Text == "" || JumlahBaru.Text == "" || CBPilihan.SelectedIndex == -1)
            {
                var Peringatan = "Anda Mungkin lupa memasukan NAMA atau JUMLAH yang Anda masukan 0";
                MessageBox.Show(Peringatan, "ALERT!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Barang.CheckNama(BarangBaru.Text))
            {
                MessageBox.Show("Maaf Barang sudah ada", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string tanggal = "";
            int nilaiPerubahan = int.Parse(JumlahBaru.Text == "" ? "0" : JumlahBaru.Text);
            Kategori selectedKategori = KoleksiKategori[CBPilihan.SelectedIndex];
            Barang barang = Barang.Create(
                BarangBaru.Text,
                nilaiPerubahan,
                tanggal,
                selectedKategori.Id
            );
            History.Create(barang.Id, nilaiPerubahan, "Barang Baru");

            MessageBox.Show($"Barang {barang.Nama} berhasil di buat", "Peringatan!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ReloadBarang();
            ReloadHistory();
        }

        private void JumlahBaru_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = OnlyNum(e);
        }
        
        private void BtnRestock_Click(object sender, EventArgs e)
        {
           if (ComBoxRestock.SelectedIndex == -1 || JumlahPenambahan.Text == "")
           {
                var Peringatan = "Anda Mungkin lupa memasukan NAMA atau JUMLAH yang Anda masukan 0";
                MessageBox.Show(Peringatan, "ALERT!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
           }
            Barang pilihanBarang = KoleksiBarang[ComBoxRestock.SelectedIndex];

            int jumlahPenambahanBarang = pilihanBarang.Jumlah + int.Parse(JumlahPenambahan.Text);
            Barang.Update(pilihanBarang.Id,jumlahPenambahanBarang);

            History.Create(pilihanBarang.Id, int.Parse(JumlahPenambahan.Text),"Restock Barang");

            ReloadBarang();
            ReloadHistory();
        }

        private void JumlahPenambahan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = OnlyNum(e);
        }

        private void BtnKurang_Click(object sender, EventArgs e)
        {
            if(ComBoxKeluar.Text=="" || ComBoxKeluar.SelectedIndex == -1)
            {
                var Peringatan = "Anda Mungkin lupa memasukan NAMA atau JUMLAH yang Anda masukan 0";
                MessageBox.Show(Peringatan, "ALERT!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Barang pilihanBarang = KoleksiBarang[ComBoxKeluar.SelectedIndex];
            int jumlahPenambahanBarang = pilihanBarang.Jumlah - int.Parse(JumlahPengambilan.Text);
            Barang.Update(pilihanBarang.Id, jumlahPenambahanBarang);

            History.Create(pilihanBarang.Id, int.Parse(JumlahPenambahan.Text), "Pengurangan Barang");

            ReloadBarang();
            ReloadHistory();

        }

        private void JumlahPengambilan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = OnlyNum(e);
        }


        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (LstData.Items.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data barang ingin di hapus?", "konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (konfirmasi == DialogResult.Yes)
                {
                   var selectedProdukIndex = LstData.SelectedIndices[0];
                    Barang selecetedbarang = KoleksiBarang[selectedProdukIndex];

                    History.Create(selecetedbarang.Id, '0', "Barang Sudah Di Hapus");
                    ComBoxKeluar.Items.Remove(selecetedbarang);
                    ComBoxRestock.Items.Remove(selecetedbarang);

                    Barang.Delete(selecetedbarang.Id);
                    ReloadBarang();
                    ReloadHistory();
                }              
            }
            else
            {
                MessageBox.Show("Data barang belum dipilih !!!", "Peringatan",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LogoutPetugas_Click(object sender, EventArgs e)
        {
            LOGIN f1 = new LOGIN();
            f1.Show();
            this.Hide();
        }
    }
}