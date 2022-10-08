using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class SinavNotlari : Form
    {
        public SinavNotlari()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string nickname;
        public string name;
        public string surname;
        private void verilerigoster()
        {
            DataTable dt= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Ad,Soyad,Matsonucu,Pcsonucu from KullaniciBilgiler where Kullaniciid="+label2.Text, bgl.baglanti());

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void SinavNotlari_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            // TODO: Bu kod satırı 'sinavsistemiDataSet2.KullaniciBilgiler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullaniciBilgilerTableAdapter.Fill(this.sinavsistemiDataSet2.KullaniciBilgiler);
            label2.Text = nickname;
            label3.Text = name;
            label4.Text = surname;
            verilerigoster();



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
