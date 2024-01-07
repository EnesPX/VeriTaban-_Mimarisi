using BAL;
using BEL;


namespace VeriTabanı_Mimarisi
{
    public partial class Form1 : Form
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();   

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            info.name = txtAd.Text.Trim();
            info.surname = txtSoyad.Text.Trim();
            info.no = txtNumara.Text.Trim();
            info.id = Int32.Parse(txtId.Text.Trim());

            int rows = opr.insertEmp(info);
            if (rows > 0)
            {
                MessageBox.Show("Veri başarıyla yüklendi! ");
            }
        }
    }
}