using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                txtBilgi.Text = "";
                txtBilgi.Text += textBox1.Text + "\r\n";
                txtBilgi.Text += textBox2.Text + "\r\n";
                txtBilgi.Text += textBox3.Text + "\r\n";
                decimal hesap = 0;
                if (domainUpDown1 != null && domainUpDown1.Value > 0)
                {
                    hesap += domainUpDown1.Value*12;
                    txtBilgi.Text += string.Format("Çırba{0:C}", domainUpDown1.Value*12) + "\r\n";
                }
                txtBilgi.Text += "------------";
                txtBilgi.Text += string.Format("Toplam{0:C}", hesap);
            }
        }
    }
}
