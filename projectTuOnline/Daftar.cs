using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectTuOnline
{
    public partial class Daftar : Form
    {
        CLASSES.User user = new CLASSES.User();
        public Daftar()
        {
            InitializeComponent();
        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string namaLengkap = gunaTextBoxNama.Text;
            string nim = gunaTextBoxNIM.Text;
            string email = gunaTextBoxEmail.Text;
            string password = gunaTextBoxPassword.Text;

            user.addUser(namaLengkap, nim, email, password);
            MessageBox.Show("Daftar Akun Berhasil");
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
