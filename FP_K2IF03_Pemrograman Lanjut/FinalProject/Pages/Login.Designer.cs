namespace FinalProject
{
    partial class LOGIN
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
            this.PasswordLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LoginPetugas = new System.Windows.Forms.Button();
            this.IdLogin = new System.Windows.Forms.TextBox();
            this.IDPetugas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordLogin
            // 
            this.PasswordLogin.Location = new System.Drawing.Point(74, 282);
            this.PasswordLogin.Name = "PasswordLogin";
            this.PasswordLogin.Size = new System.Drawing.Size(404, 31);
            this.PasswordLogin.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "PASSWORD";
            // 
            // LoginPetugas
            // 
            this.LoginPetugas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPetugas.Location = new System.Drawing.Point(326, 381);
            this.LoginPetugas.Name = "LoginPetugas";
            this.LoginPetugas.Size = new System.Drawing.Size(152, 44);
            this.LoginPetugas.TabIndex = 5;
            this.LoginPetugas.Text = "Login";
            this.LoginPetugas.UseVisualStyleBackColor = true;
            this.LoginPetugas.Click += new System.EventHandler(this.LoginPetugas_Click);
            // 
            // IdLogin
            // 
            this.IdLogin.Location = new System.Drawing.Point(73, 145);
            this.IdLogin.Name = "IdLogin";
            this.IdLogin.Size = new System.Drawing.Size(404, 31);
            this.IdLogin.TabIndex = 2;
            // 
            // IDPetugas
            // 
            this.IDPetugas.AutoSize = true;
            this.IDPetugas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPetugas.Location = new System.Drawing.Point(74, 86);
            this.IDPetugas.Name = "IDPetugas";
            this.IDPetugas.Size = new System.Drawing.Size(148, 25);
            this.IDPetugas.TabIndex = 1;
            this.IDPetugas.Text = "ID PETUGAS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClearLogin);
            this.panel1.Controls.Add(this.IDPetugas);
            this.panel1.Controls.Add(this.PasswordLogin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LoginPetugas);
            this.panel1.Controls.Add(this.IdLogin);
            this.panel1.Location = new System.Drawing.Point(532, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 516);
            this.panel1.TabIndex = 8;
            // 
            // ClearLogin
            // 
            this.ClearLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLogin.Location = new System.Drawing.Point(94, 381);
            this.ClearLogin.Name = "ClearLogin";
            this.ClearLogin.Size = new System.Drawing.Size(152, 44);
            this.ClearLogin.TabIndex = 9;
            this.ClearLogin.Text = "Clear";
            this.ClearLogin.UseVisualStyleBackColor = true;
            this.ClearLogin.Click += new System.EventHandler(this.ClearLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.w;
            this.pictureBox1.Location = new System.Drawing.Point(76, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 795);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label IDPetugas;
        private System.Windows.Forms.TextBox IdLogin;
        private System.Windows.Forms.Button LoginPetugas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClearLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}