using System.Data;
using System.Windows.Forms;

namespace ornek4
{
    public partial class Form1 : Form
    {
        DataTable tablo = new DataTable();
        DataTable tablo2 = new DataTable();
        public Hayvan Hayvan = new Hayvan();
        public List<Hayvan> Hayvanlar = new List<Hayvan>();
        public List<Sahip> Sahipler { get; set; } = new List<Sahip>();
        public Form1()
        {
            InitializeComponent();
            tablo.Columns.Add("Sahip Adý", typeof(string));
            tablo.Columns.Add("Evcil hayvan Adý", typeof(string));
            tablo.Columns.Add("Tür", typeof(string));
            tablo.Columns.Add("AyakSayýsý", typeof(uint));
            tablo.Columns.Add("Memeli", typeof(string));
            dataGridView1.DataSource = tablo;
            tablo2.Columns.Add("Hayvan Adý", typeof(string));
            tablo2.Columns.Add("Ayak Sayýsý", typeof(string));
            tablo2.Columns.Add("Memeli", typeof(string));
            dataGridView1.DataSource = tablo2;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var hayvan = new Hayvan();
            hayvan.adi = textBox1.Text;
            hayvan.AyakSayýsý = uint.Parse(textBox2.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                hayvan.Memeli = true;

            }
            else
            {
                hayvan.Memeli = false;
            }
            Hayvanlar.Add(hayvan);
            tablo2.Rows.Add(hayvan.adi, hayvan.AyakSayýsý, hayvan.Memeli.ToString());
            dataGridView1.DataSource = tablo2;
            comboBox2.Items.Add(hayvan.adi);
            Hayvan = hayvan;
            MessageBox.Show($"Kayýt Eklendi");
            textBox1.Clear();
            textBox2.Clear();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            var sahip = new Sahip();
            sahip.SahipAdý = textBox3.Text;
            sahip.HayvanAdi = textBox4.Text;
            sahip.Hayvan = comboBox2.SelectedItem.ToString();
            sahip.adi = Hayvan.adi;
            sahip.AyakSayýsý = Hayvan.AyakSayýsý;
            sahip.Memeli = Hayvan.Memeli;
            Sahipler.Add(sahip);
            MessageBox.Show($"Kayýt Eklendi");
            tablo.Rows.Add(sahip.SahipAdý, sahip.HayvanAdi, sahip.Hayvan, sahip.AyakSayýsý, sahip.Memeli.ToString());
            dataGridView1.DataSource = tablo;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}