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
    public partial class suratDiproses4 : Form
    {
        public suratDiproses4()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            editPengajuan editpengajuan = new editPengajuan();
            editpengajuan.ShowDialog();
            this.Close();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotifikasiBatal notifikasiBatal = new NotifikasiBatal();
            notifikasiBatal.ShowDialog();
            this.Close();
        }
    }
}
