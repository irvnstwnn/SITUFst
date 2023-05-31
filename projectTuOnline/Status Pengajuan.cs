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
    public partial class Status_Pengajuan : Form
    {
        public Status_Pengajuan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            suratDiproses suratdiproses = new suratDiproses();
            suratdiproses.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            suratDiproses2 suratdiproses2 = new suratDiproses2();   
            suratdiproses2.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            suratDiproses3 suratdiproses3 = new suratDiproses3();
            suratdiproses3.ShowDialog();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            suratDiproses4 suratdiproses4 = new suratDiproses4();
            suratdiproses4.ShowDialog();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            SuratDiproses5 suratDiproses5 = new SuratDiproses5();
            suratDiproses5.ShowDialog();
        }
    }
}
