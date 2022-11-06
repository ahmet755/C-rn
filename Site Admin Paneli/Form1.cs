using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Site_Admin_Paneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SayfaOlustur_Click(object sender, EventArgs e)
        {
            var write = new StreamWriter($"./{textBox1.Text}.html");
      
            SaveFileDialog dosyakaydet = new SaveFileDialog();
            var html = $"<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    " +
                $"<meta charset=\"UTF-8\">\r\n    " + $"<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n   " +
                $" <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    " +
                $"<title>{textBox2.Text}</title>\r\n</head>\r\n<body>\r\n<h1>{textBox3.Text}</h1><hr><p>{richTextBox1.Text}</p><hr><a href='{textBox4.Text}'>{textBox5.Text}</a> \r\n</body>\r\n</html>\r\n";
            write.Write(html);
            write.Close();
            if (dosyakaydet.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dosyakaydet.FileName, html, Encoding.UTF8);
                write.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
