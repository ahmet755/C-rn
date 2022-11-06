using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace örnek3
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public OpenFileDialog ofd;
        private void button3_Click(object sender, EventArgs e)
        {
            //TextWriter writer = new StreamWriter("./test.txt");
            // writer.WriteLine("bu bir denemedir.");
            //writer.Close();
            ofd = new OpenFileDialog();
            ofd.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ofd == null || string.IsNullOrEmpty(ofd.FileName))MessageBox.Show("Dosya Seç Adamın Canını Sıkma!!!");
            else
            {
                var dosya = new StreamReader(ofd.InitialDirectory + ofd.FileName);
                richTextBox1.Text = dosya.ReadToEnd();
                dosya.Close();
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ofd == null || string.IsNullOrEmpty(ofd.FileName)) MessageBox.Show("Dosya Seç Adamın Canını Sıkma!!!");
            else
            {
                TextWriter writer = new StreamWriter(ofd.InitialDirectory + ofd.FileName);
                writer.Write(richTextBox1.Text);
                writer.Close();
            }
        }
    }
}
