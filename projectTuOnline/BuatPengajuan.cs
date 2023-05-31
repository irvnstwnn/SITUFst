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
    public partial class BuatPengajuan : Form
    {
        public BuatPengajuan()
        {
            InitializeComponent();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notifikasi notifikasi = new Notifikasi();
            notifikasi.ShowDialog();
            this.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // image types
            opf.Filter = "Choose Image(*.pdf;*.jpg;*.png;*.gif)|*.pdf;*.jpg;*.png;*.gif";

            if(opf.ShowDialog() == DialogResult.OK)
            {
                NotifikasiTambahFile notifikasiTambahFile = new NotifikasiTambahFile();
                notifikasiTambahFile.ShowDialog();
            }
        }
    }
}
