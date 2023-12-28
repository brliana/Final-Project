namespace FinalProject
{
    partial class Gudang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarangBaru = new System.Windows.Forms.TextBox();
            this.JumlahBaru = new System.Windows.Forms.TextBox();
            this.BtnBaru = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogoutPetugas = new System.Windows.Forms.Button();
            this.LstData = new System.Windows.Forms.ListView();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CBPilihan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ClearBaru = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComBoxRestock = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.JumlahPenambahan = new System.Windows.Forms.TextBox();
            this.ClearPenambahan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRestock = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ComBoxKeluar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ClearPengambilan = new System.Windows.Forms.Button();
            this.BtnBarangKeluar = new System.Windows.Forms.Button();
            this.JumlahPengambilan = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LstHistory = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarangBaru
            // 
            this.BarangBaru.Location = new System.Drawing.Point(148, 29);
            this.BarangBaru.Name = "BarangBaru";
            this.BarangBaru.Size = new System.Drawing.Size(209, 22);
            this.BarangBaru.TabIndex = 0;
            // 
            // JumlahBaru
            // 
            this.JumlahBaru.Location = new System.Drawing.Point(148, 59);
            this.JumlahBaru.Name = "JumlahBaru";
            this.JumlahBaru.Size = new System.Drawing.Size(209, 22);
            this.JumlahBaru.TabIndex = 1;
            this.JumlahBaru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JumlahBaru_KeyPress);
            // 
            // BtnBaru
            // 
            this.BtnBaru.Location = new System.Drawing.Point(149, 120);
            this.BtnBaru.Name = "BtnBaru";
            this.BtnBaru.Size = new System.Drawing.Size(86, 33);
            this.BtnBaru.TabIndex = 2;
            this.BtnBaru.Text = "Simpan";
            this.BtnBaru.UseVisualStyleBackColor = true;
            this.BtnBaru.Click += new System.EventHandler(this.BtnBaru_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LogoutPetugas);
            this.groupBox1.Controls.Add(this.LstData);
            this.groupBox1.Controls.Add(this.BtnHapus);
            this.groupBox1.Location = new System.Drawing.Point(435, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 410);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSEDIAAN BARANG GUDANG";
            // 
            // LogoutPetugas
            // 
            this.LogoutPetugas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutPetugas.Location = new System.Drawing.Point(706, 19);
            this.LogoutPetugas.Name = "LogoutPetugas";
            this.LogoutPetugas.Size = new System.Drawing.Size(103, 32);
            this.LogoutPetugas.TabIndex = 8;
            this.LogoutPetugas.Text = "Logout";
            this.LogoutPetugas.UseVisualStyleBackColor = true;
            this.LogoutPetugas.Click += new System.EventHandler(this.LogoutPetugas_Click);
            // 
            // LstData
            // 
            this.LstData.HideSelection = false;
            this.LstData.Location = new System.Drawing.Point(9, 63);
            this.LstData.Name = "LstData";
            this.LstData.Size = new System.Drawing.Size(801, 329);
            this.LstData.TabIndex = 0;
            this.LstData.UseCompatibleStateImageBehavior = false;
            // 
            // BtnHapus
            // 
            this.BtnHapus.Location = new System.Drawing.Point(157, 21);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(75, 35);
            this.BtnHapus.TabIndex = 6;
            this.BtnHapus.Text = "Hapus";
            this.BtnHapus.UseVisualStyleBackColor = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.CBPilihan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.ClearBaru);
            this.groupBox2.Controls.Add(this.BtnBaru);
            this.groupBox2.Controls.Add(this.JumlahBaru);
            this.groupBox2.Controls.Add(this.BarangBaru);
            this.groupBox2.Location = new System.Drawing.Point(26, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 166);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BARANG BARU ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 90);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "KATEGORI";
            // 
            // CBPilihan
            // 
            this.CBPilihan.FormattingEnabled = true;
            this.CBPilihan.Location = new System.Drawing.Point(149, 90);
            this.CBPilihan.Name = "CBPilihan";
            this.CBPilihan.Size = new System.Drawing.Size(209, 24);
            this.CBPilihan.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "NAMA BARANG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "JUMLAH";
            // 
            // ClearBaru
            // 
            this.ClearBaru.Location = new System.Drawing.Point(261, 122);
            this.ClearBaru.Name = "ClearBaru";
            this.ClearBaru.Size = new System.Drawing.Size(91, 31);
            this.ClearBaru.TabIndex = 5;
            this.ClearBaru.Text = "Clear";
            this.ClearBaru.UseVisualStyleBackColor = true;
            this.ClearBaru.Click += new System.EventHandler(this.ClearBaru_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ComBoxRestock);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.JumlahPenambahan);
            this.groupBox3.Controls.Add(this.ClearPenambahan);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.BtnRestock);
            this.groupBox3.Location = new System.Drawing.Point(26, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 140);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RESTOCK BARANG";
            // 
            // ComBoxRestock
            // 
            this.ComBoxRestock.FormattingEnabled = true;
            this.ComBoxRestock.Location = new System.Drawing.Point(148, 34);
            this.ComBoxRestock.Name = "ComBoxRestock";
            this.ComBoxRestock.Size = new System.Drawing.Size(209, 24);
            this.ComBoxRestock.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "JUMLAH";
            // 
            // JumlahPenambahan
            // 
            this.JumlahPenambahan.Location = new System.Drawing.Point(148, 65);
            this.JumlahPenambahan.Name = "JumlahPenambahan";
            this.JumlahPenambahan.Size = new System.Drawing.Size(209, 22);
            this.JumlahPenambahan.TabIndex = 4;
            this.JumlahPenambahan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JumlahPenambahan_KeyPress);
            // 
            // ClearPenambahan
            // 
            this.ClearPenambahan.Location = new System.Drawing.Point(261, 93);
            this.ClearPenambahan.Name = "ClearPenambahan";
            this.ClearPenambahan.Size = new System.Drawing.Size(91, 29);
            this.ClearPenambahan.TabIndex = 7;
            this.ClearPenambahan.Text = "Clear";
            this.ClearPenambahan.UseVisualStyleBackColor = true;
            this.ClearPenambahan.Click += new System.EventHandler(this.ClearPenambahan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "NAMA BARANG";
            // 
            // BtnRestock
            // 
            this.BtnRestock.Location = new System.Drawing.Point(148, 93);
            this.BtnRestock.Name = "BtnRestock";
            this.BtnRestock.Size = new System.Drawing.Size(81, 31);
            this.BtnRestock.TabIndex = 2;
            this.BtnRestock.Text = "Tambah";
            this.BtnRestock.UseVisualStyleBackColor = true;
            this.BtnRestock.Click += new System.EventHandler(this.BtnRestock_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ComBoxKeluar);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.ClearPengambilan);
            this.groupBox4.Controls.Add(this.BtnBarangKeluar);
            this.groupBox4.Controls.Add(this.JumlahPengambilan);
            this.groupBox4.Location = new System.Drawing.Point(26, 413);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(371, 144);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BARANG KELUAR";
            // 
            // ComBoxKeluar
            // 
            this.ComBoxKeluar.FormattingEnabled = true;
            this.ComBoxKeluar.Location = new System.Drawing.Point(149, 29);
            this.ComBoxKeluar.Name = "ComBoxKeluar";
            this.ComBoxKeluar.Size = new System.Drawing.Size(209, 24);
            this.ComBoxKeluar.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "JUMLAH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "NAMA BARANG";
            // 
            // ClearPengambilan
            // 
            this.ClearPengambilan.Location = new System.Drawing.Point(261, 93);
            this.ClearPengambilan.Name = "ClearPengambilan";
            this.ClearPengambilan.Size = new System.Drawing.Size(91, 33);
            this.ClearPengambilan.TabIndex = 8;
            this.ClearPengambilan.Text = "Clear";
            this.ClearPengambilan.UseVisualStyleBackColor = true;
            this.ClearPengambilan.Click += new System.EventHandler(this.ClearPengambilan_Click);
            // 
            // BtnBarangKeluar
            // 
            this.BtnBarangKeluar.Location = new System.Drawing.Point(148, 93);
            this.BtnBarangKeluar.Name = "BtnBarangKeluar";
            this.BtnBarangKeluar.Size = new System.Drawing.Size(87, 33);
            this.BtnBarangKeluar.TabIndex = 4;
            this.BtnBarangKeluar.Text = "Ambil";
            this.BtnBarangKeluar.UseVisualStyleBackColor = true;
            this.BtnBarangKeluar.Click += new System.EventHandler(this.BtnKurang_Click);
            // 
            // JumlahPengambilan
            // 
            this.JumlahPengambilan.Location = new System.Drawing.Point(149, 65);
            this.JumlahPengambilan.Name = "JumlahPengambilan";
            this.JumlahPengambilan.Size = new System.Drawing.Size(209, 22);
            this.JumlahPengambilan.TabIndex = 3;
            this.JumlahPengambilan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JumlahPengambilan_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LstHistory);
            this.groupBox5.Location = new System.Drawing.Point(435, 11);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(827, 387);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "RIWAYAT";
            // 
            // LstHistory
            // 
            this.LstHistory.HideSelection = false;
            this.LstHistory.Location = new System.Drawing.Point(9, 28);
            this.LstHistory.Margin = new System.Windows.Forms.Padding(2);
            this.LstHistory.Name = "LstHistory";
            this.LstHistory.Size = new System.Drawing.Size(814, 345);
            this.LstHistory.TabIndex = 0;
            this.LstHistory.UseCompatibleStateImageBehavior = false;
            // 
            // Gudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 829);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Gudang";
            this.Text = "GUDANG";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox BarangBaru;
        private System.Windows.Forms.TextBox JumlahBaru;
        private System.Windows.Forms.Button BtnBaru;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.ListView LstData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox JumlahPenambahan;
        private System.Windows.Forms.Button BtnRestock;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnBarangKeluar;
        private System.Windows.Forms.TextBox JumlahPengambilan;
        private System.Windows.Forms.Button ClearBaru;
        private System.Windows.Forms.Button ClearPenambahan;
        private System.Windows.Forms.Button ClearPengambilan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView LstHistory;
        private System.Windows.Forms.Button LogoutPetugas;
        private System.Windows.Forms.ComboBox CBPilihan;
        private System.Windows.Forms.ComboBox ComBoxRestock;
        private System.Windows.Forms.ComboBox ComBoxKeluar;
        private System.Windows.Forms.Label label13;
    }
}

