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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            container(new Beranda());
        }

        public void container(object _form)
        {
            if (gunaPanelContainer.Controls.Count > 0) gunaPanelContainer.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            gunaPanelContainer.Controls.Add(fm);
            gunaPanelContainer.Tag = fm;
            fm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            container(new Status_Pengajuan());
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.FromArgb(56, 182, 255);
            label3.ForeColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            container(new Profile());
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.FromArgb(56, 182, 255);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            container(new Beranda());
            label1.ForeColor = Color.FromArgb(56, 182, 255);
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
        }
    }
}
