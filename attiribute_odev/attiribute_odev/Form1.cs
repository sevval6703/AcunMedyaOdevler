namespace attiribute_odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string isim=txtAd.Text;
            string soyisim=txtSoyad.Text;
            string bolum=txtBolum.Text;
            lblVeri.Text = isim + soyisim + bolum;
        }
    }
}
