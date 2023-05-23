using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tatil_Rezervasyon_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            otelArama.BackColor = SystemColors.Window;
            turArama.BackColor = SystemColors.GrayText;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

        private void turlarButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void turArama_Click(object sender, EventArgs e)
        {
            otelArama.BackColor = SystemColors.GrayText;
            turArama.BackColor = SystemColors.Window;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }
        private void otelArama_Click(object sender, EventArgs e)
        {
            otelArama.BackColor = SystemColors.Window;
            turArama.BackColor = SystemColors.GrayText;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

        private void otellerButton_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.Show();
        }

        private void kampanyalarButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }
    }
}
