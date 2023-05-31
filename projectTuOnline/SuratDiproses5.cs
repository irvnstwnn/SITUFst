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
    public partial class SuratDiproses5 : Form
    {
        public SuratDiproses5()
        {
            InitializeComponent();
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            filePDF filePDF = new filePDF();
            filePDF.ShowDialog();
        }
    }
}
