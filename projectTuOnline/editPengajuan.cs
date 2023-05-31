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
    public partial class editPengajuan : Form
    {
        public editPengajuan()
        {
            InitializeComponent();
        }

        private void editPengajuan_Load(object sender, EventArgs e)
        {
            gunaTextBox1.Text = "Surat Permohonan Konversi";
            gunaTextBox2.Text = "30 Januari 2023";
            gunaTextBox3.Text = "Tidak Ada";
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifikasiEdit notifikasiedit = new notifikasiEdit();
            notifikasiedit.ShowDialog();
            this.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // image types
            opf.Filter = "Choose Image(*.pdf;*.jpg;*.png;*.gif)|*.pdf;*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                NotifikasiTambahFile notifikasiTambahFile = new NotifikasiTambahFile();
                notifikasiTambahFile.ShowDialog();
            }
        }
    }
}
