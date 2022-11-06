using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace örnek2
{
    public partial class Form1 : Form
    {
        public int sayi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                listBox1.Items.Add("seçtiğin Nesne ");
            }
            else if (checkBox1.Checked==false)
            {
                listBox1.Items.Add("seçmedin Nesneyi ");
            }
            MessageBox.Show("niye tıkladın");
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //if (checkBox1.Checked == true)
            //{
            // listBox1.Items.Add("seçtiğin Nesne ");
            //}
            //else if (checkBox1.Checked == false)
            // {
            //  listBox1.Items.Add("seçmedin Nesneyi ");
            //}
            MessageBox.Show("niye tıkladın?");
            Random rand = new Random();
            string yazi = RandomString(8);
            int number1 = rand.Next(0, 400); //returns random number between 0-99
            int number2 = rand.Next(0, 400);
            //buttona bastığın anda yeni buton oluşturma 
            //Button yeni_button = new Button();
            //this.Controls.Add(yeni_button);
            //butona yazı yazdırma
           // yeni_button.Text =Convert.ToString(yazi);
            //penceredeki yerini belirieme       
           // yeni_button.Text = yazi;
            //yeni_button.Location = new Point(number1, number2);
            //yeni_button.Click += (s, e) => { MessageBox.Show(yeni_button.Text); };           
            listBox1.Items.Add(yazi);
    
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random rand = new Random();
            string yazi = RandomString(8);
            int number1 = rand.Next(0, 400); //returns random number between 0-99
            int number2 = rand.Next(0, 400);
            //buttona bastığın anda yeni buton oluşturma 
            Button yeni_button = new Button();
            this.Controls.Add(yeni_button);
            //butona yazı yazdırma
            yeni_button.Text = Convert.ToString(yazi);
            //penceredeki yerini belirieme       
            yeni_button.Text = yazi;
            yeni_button.Location = new Point(number1, number2);
            yeni_button.Click += (s, e) => { MessageBox.Show(yeni_button.Text); };
            listBox1.Items.Add(yazi);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
             sayi = rand.Next(0, 100);
            Label yeni_label = new Label();
            this.Controls.Add(yeni_label);
            yeni_label.Text ="Sayı Tutuldu";
            yeni_label.Location = new Point(12, 265);
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            int tahmin_sayi = Convert.ToInt32(textBox1.Text);
            if (tahmin_sayi > 100 || tahmin_sayi < 0)
            {
                MessageBox.Show("Geçerli Bir Sayi Gir!!!");
            }
            else if(tahmin_sayi == sayi)
            {
                MessageBox.Show("Kazandın!!!");
            }
            else if (sayi>=50)
            {
                Label yeni_label = new Label();
                this.Controls.Add(yeni_label);
                yeni_label.Text = "Tutğum sayı 50 den küçük";
                yeni_label.Location = new Point(12, 265);
            }
            else if (sayi<=50)
            {
                Label yeni_label = new Label();
                this.Controls.Add(yeni_label);
                yeni_label.Text = "Tutğum sayı 50 den büyük";
                yeni_label.Location = new Point(12, 265);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
