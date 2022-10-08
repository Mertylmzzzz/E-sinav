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
    public partial class İletisim : Form
    {
        public İletisim()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        public string ad, soyad;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into İletisim (İletisimad,İletisimsoyad,İletisimmail,İletisimsikayet) values(@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            komut.Parameters.AddWithValue("@p4", richTextBox1.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Şikayetiniz İletilmiştir Sayın " + textBox1.Text + " " + textBox2.Text);

        }

        private void İletisim_Load(object sender, EventArgs e)
        {
            textBox1.Text = ad;
            textBox2.Text = soyad;
            dataGridView1.Visible = false;
        }
    }
}
