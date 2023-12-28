using System;
using System.Windows.Forms;
using FinalProject.Database.Repository;

namespace FinalProject
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LoginPetugas_Click(object sender, EventArgs e)
        {
            string username = IdLogin.Text;
            string password = PasswordLogin.Text;

            User loggedInUser = User.GetUserFromUsernameAndPassword(username, password);


            if (loggedInUser != null)
            {
                MessageBox.Show("Anda berhasil Login");
                Gudang f1 = new Gudang();
                f1.Show();
                this.Hide();
            }
            else if (IdLogin.Text == " " &&  PasswordLogin.Text == " ")
            {
                MessageBox.Show("Masukan Id dan Password!!","Peringatan",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Id atau Password Anda salah!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            return;

        }

        private void ClearLogin_Click(object sender, EventArgs e)
        {
            IdLogin.Clear();
            PasswordLogin.Clear();
            IdLogin.Focus();
        }
    }
}