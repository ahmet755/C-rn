namespace örnek_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Mesaj> mesajlar = new List<Mesaj>();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                StreamReader sr = new StreamReader("./" + i + "txt");
                string icerik = sr.ReadToEnd();
                // MessageBox.Show(icerik);
                Mesaj mesaj = new Mesaj();
                mesaj.baslık = Convert.ToString(i);
                mesaj.icerik = icerik;
                mesajlar.Add(mesaj);


            }
           
        }
    }
}