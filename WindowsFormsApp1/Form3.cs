using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SinavNotlari sn = new SinavNotlari();
            sn.nickname = label8.Text;
            sn.surname = label7.Text;
            sn.name = label5.Text;


            sn.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sınavsistemi sınav = new sınavsistemi();
            sınav.kullaniciad = label8.Text;
            sınav.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public string kullaniciad;
        private void Form3_Load(object sender, EventArgs e)
        {
            label8.Visible = false;
            Form2 form2 = new Form2();
            label3.Text = kullaniciad;
            SqlCommand komut = new SqlCommand("select * from KullaniciBilgiler where Kullaniciad=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",label3.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                label8.Text = dr[0].ToString();
                label5.Text = dr[1].ToString();
                label7.Text= dr[2].ToString();
                
            }
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mufredat m = new mufredat();
            m.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            İletisim i = new İletisim();
            i.ad = label5.Text;
            i.soyad = label7.Text;
            i.Show();
        }
    }
}
