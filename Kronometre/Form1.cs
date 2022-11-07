using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye = 0, dakika = 0, saat = 0;

        private void BtnSıfırla_Click(object sender, EventArgs e)
        {
            saniye = 0;
            dakika = 0;
            saat = 0;
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            listBox1.Items.Clear();
        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void BtnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void BtnTur_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(saat + ":" + dakika + ":" + saniye);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label3.Text = saniye.ToString();
            if (saniye == 60)
            {
                dakika++;
                label2.Text = dakika.ToString();
                saniye = 0;
                if (dakika == 60)
                {
                    saat++;
                    label1.Text = saat.ToString();
                    saniye = 0;
                }
            }
        }
    }
}
