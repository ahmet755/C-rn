using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Örnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double say1, say2, sonuc, toplam;
            say1 = Convert.ToDouble(textBox1.Text);
            say2 = Convert.ToDouble(textBox1.Text);
            sonuc = say1+say2;
            toplam = sonuc;
            textBox1.Text = toplam.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Seçim Yaptınız");
            }
            else
            {
                MessageBox.Show("Seçim yapmadınız");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Double say1,  sonuc;
            say1 = Convert.ToDouble(textBox1.Text);
            sonuc = say1 / say1;
            textBox1.Text = sonuc.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double say1,  sonuc;
            say1 = Convert.ToDouble(textBox1.Text);
            sonuc = say1 * say1;
            textBox1.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double say1,  sonuc;
            say1 = Convert.ToDouble(textBox1.Text);
            sonuc = say1 - say1;
            textBox1.Text = sonuc.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
    }
}
